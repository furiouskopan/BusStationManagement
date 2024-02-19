using BusStationInterface.Data;
using BusStationInterface.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusStationInterface.Forms
{
    public partial class SimulationForm : Form
    {
        private BusSimulationService _simulationService;
        private CancellationTokenSource _cancellationTokenSource;
        private BusManagementContext _context;
        private DateTime _simulationStartTime;
        private int totalDuration;
        private int _currentBusId;

        internal SimulationForm(BusSimulationService simulationService, BusManagementContext context)
        {
            InitializeComponent();
            _simulationService = simulationService;
            _cancellationTokenSource = new CancellationTokenSource();
            _context = context;

            // Subscribe to the simulation service's update event
            _simulationService.OnUpdateStatus += UpdateSimulationLog;
            _simulationService.OnCurrentStopChanged += SimulationService_OnCurrentStopChanged;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            PopulateRoutesComboBox();
            InitializeDataGridView();
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            if (cmbSchedules.SelectedValue is int selectedScheduleId)
            {
                _currentBusId = GetBusIdFromSchedule(selectedScheduleId) ?? -1;
                if (_currentBusId != -1)
                {
                    totalDuration = GetTotalSimulationDurationInMilliseconds(selectedScheduleId);
                    _simulationStartTime = DateTime.Now;
                    progressBar.Maximum = 100;
                    Task.Run(() => _simulationService.SimulateBusRoute(selectedScheduleId, _cancellationTokenSource.Token));
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("The selected schedule was not found. Please select a valid schedule.", "Schedule Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a schedule to start the simulation.", "No Schedule Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetTotalSimulationDurationInMilliseconds(int scheduleId)
        {
            var schedule = _context.Schedules
                .Include(s => s.Route)
                    .ThenInclude(r => r.RouteDetails)
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null || schedule.Route.RouteDetails == null)
            {
                return 0; // Or handle this case as needed.
            }

            // Since each minute in real time is simulated as 100 milliseconds
            int totalDurationInMilliseconds = schedule.Route.RouteDetails.Sum(rd => rd.Time) * 100;
            return totalDurationInMilliseconds;
        }

        private void btnStopSimulation_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            timer1.Stop();
        }

        private void UpdateSimulationLog(string message)
        {
            if (lstSimulationLog.InvokeRequired)
            {
                lstSimulationLog.Invoke(new Action(() => lstSimulationLog.Items.Add(message)));
            }
            else
            {
                lstSimulationLog.Items.Add(message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var elapsedMilliseconds = (DateTime.Now - _simulationStartTime).TotalMilliseconds;
            var progressPercentage = (int)((elapsedMilliseconds / totalDuration) * 100);
            progressBar.Value = Math.Min(progressPercentage, 100); // Ensure it does not exceed 100%

            // Calculate remaining time in milliseconds and convert it to seconds
            var remainingMilliseconds = totalDuration - elapsedMilliseconds;
            var remainingSeconds = remainingMilliseconds / 1000; // Convert milliseconds to seconds

            // Update the remaining time label to display remaining time in seconds
            remainingLabel.Text = $"Remaining Time: {Math.Max(0, (int)remainingSeconds)} seconds"; // Ensure remaining time doesn't go below 0

            if (progressPercentage >= 100)
            {
                timer1.Stop();
                remainingLabel.Text = "Time's up!";
            }
        }

        private void PopulateRoutesComboBox()
        {
            var routes = _context.Routes.Select(r => new { r.RouteID, r.Description }).ToList();
            cmbRoutes.DisplayMember = "Description";
            cmbRoutes.ValueMember = "RouteID";
            cmbRoutes.DataSource = routes;
        }
        private void PopulateSchedulesComboBox(int routeId)
        {
            // Assuming you have a DbContext named _context
            var schedules = _context.Schedules
                                   .Where(s => s.RouteID == routeId)
                                   .Select(s => new { s.ScheduleID, DisplayValue = s.DepartureTime.ToString() })
                                   .ToList();

            // Clear existing items
            cmbSchedules.DataSource = null;
            cmbSchedules.Items.Clear();

            // Set the DataSource to the fetched schedules
            cmbSchedules.DisplayMember = "DisplayValue";
            cmbSchedules.ValueMember = "ScheduleID";
            cmbSchedules.DataSource = schedules;
        }

        private void cmbSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSchedules.SelectedValue is int selectedScheduleId)
            {
                var schedule = _context.Schedules
                    .Include(s => s.Route)
                        .ThenInclude(r => r.RouteDetails)
                    .FirstOrDefault(s => s.ScheduleID == selectedScheduleId);

                if (schedule == null)
                {
                    MessageBox.Show("Selected schedule was not found.");
                    return;
                }

                if (schedule.Route == null)
                {
                    MessageBox.Show("No route associated with the selected schedule.");
                    return;
                }

                if (schedule.Route.RouteDetails == null || !schedule.Route.RouteDetails.Any())
                {
                    MessageBox.Show("No route details associated with the route of the selected schedule.");
                    return;
                }

                int currentRouteDetailId = schedule.Route.RouteDetails
                    .OrderBy(rd => rd.SequenceNumber)
                    .FirstOrDefault()?.RouteDetailID ?? -1;

                if (currentRouteDetailId == -1)
                {
                    MessageBox.Show("Could not find the first route detail for the selected schedule.");
                    return;
                }

                _currentBusId = schedule.BusID; // Set the currentBusId here based on the selected schedule
                PopulateSeats(_currentBusId, currentRouteDetailId);
            }
        }

        private void InitializeDataGridView()
        {
            if (dataGridView1 == null)
            {
                throw new InvalidOperationException("DataGridView is not initialized.");
            }

            // Clear any existing columns before adding new ones
            dataGridView1.Columns.Clear();

            // Add the SeatNumber and IsOccupied columns
            dataGridView1.Columns.Add("SeatNumber", "Seat Number");
            dataGridView1.Columns.Add("IsOccupied", "Occupied Status");

            // Optional properties for better visual representation
        }
        private void PopulateSeats(int busId, int currentRouteDetailId)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                InitializeDataGridView();
            }
            if (InvokeRequired)
            {
                Invoke(new Action(() => PopulateSeats(busId, currentRouteDetailId)));
            }
            else
            {
                var seats = _context.Seats.Where(s => s.BusID == busId).ToList();
                dataGridView1.Rows.Clear();

                foreach (var seat in seats)
                {
                    bool isOccupied = _context.Tickets.Any(t => t.SeatID == seat.SeatID &&
                        t.StartRouteDetailID <= currentRouteDetailId &&
                        t.EndRouteDetailID >= currentRouteDetailId);

                    dataGridView1.Rows.Add(seat.SeatNumber, isOccupied ? "Occupied" : "Free");
                }
            }
        }

        public void UpdateSeatStatus(int seatId, bool isOccupied)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateSeatStatus(seatId, isOccupied)));
            }
            else
            {
                var seat = _context.Seats.FirstOrDefault(s => s.SeatID == seatId);
                if (seat != null)
                {
                    seat.IsOccupied = isOccupied;
                    _context.SaveChanges();

                    // Update the DataGridView to reflect the change
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["SeatNumber"].Value.ToString() == seat.SeatNumber)
                        {
                            row.Cells["IsOccupied"].Value = isOccupied ? "Occupied" : "Free";
                            break;
                        }
                    }
                    dataGridView1.Refresh();
                }
            }
        }

        private int? GetBusIdFromSchedule(int scheduleId)
        {
            var schedule = _context.Schedules.FirstOrDefault(s => s.ScheduleID == scheduleId);
            return schedule?.BusID; // This will return null if the schedule is not found
        }

        //private int GetCurrentRouteDetailIdForStop(int stopId, int scheduleId)
        //{
        //    var routeDetail = _context.RouteDetails
        //        .Include(rd => rd.Route) // Include Route to access the RouteDetails
        //        .Where(rd => rd.LocationID == stopId && rd.Route.Schedules.Any(s => s.ScheduleID == scheduleId))
        //        .OrderBy(rd => rd.SequenceNumber)
        //        .FirstOrDefault();
        //    return routeDetail?.RouteDetailID ?? -1;
        //}
        private void SimulationService_OnCurrentStopChanged(int currentRouteDetailId)
        {
            // Ensure the UI update is performed on the UI thread
            this.Invoke((MethodInvoker)delegate
            {
                PopulateSeats(_currentBusId, currentRouteDetailId);
            });
        }
        private void RefreshSeatOccupancyDisplay(int currentRouteDetailId)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => RefreshSeatOccupancyDisplay(currentRouteDetailId)));
                return;
            }

            // Assuming _context is your EF DbContext and dataGridView1 is your DataGridView
            var seats = _context.Seats.ToList(); // Consider filtering by bus if necessary
            var tickets = _context.Tickets
                                  .Include(t => t.StartRouteDetail)
                                  .Include(t => t.EndRouteDetail)
                                  .ToList();

            dataGridView1.Rows.Clear();

            foreach (var seat in seats)
            {
                // Determine if the seat is occupied at the current stop
                bool isOccupied = tickets.Any(t => t.SeatID == seat.SeatID &&
                                                   t.StartRouteDetailID <= currentRouteDetailId &&
                                                   t.EndRouteDetailID >= currentRouteDetailId);

                dataGridView1.Rows.Add(seat.SeatNumber, isOccupied ? "Occupied" : "Free");
            }
        }

        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoutes.SelectedValue is int selectedRouteId)
            {
                PopulateSchedulesComboBox(selectedRouteId);
            }
        }
    }
}
