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

        internal SimulationForm(BusSimulationService simulationService, BusManagementContext context)
        {
            InitializeComponent();
            _simulationService = simulationService;
            _cancellationTokenSource = new CancellationTokenSource();
            _context = context;

            // Subscribe to the simulation service's update event
            _simulationService.OnUpdateStatus += UpdateSimulationLog;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            PopulateRoutesComboBox();
            InitializeDataGridView();
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            // Start the simulation
            int selectedScheduleId = (int)cmbRoutes.SelectedValue;
            Task.Run(() => _simulationService.SimulateBusRoute(selectedScheduleId, _cancellationTokenSource.Token));
            progressBar.Value = 0;
            elapsedTime = 0;
            timer1.Start();
        }

        private void btnStopSimulation_Click(object sender, EventArgs e)
        {
            // Stop the simulation
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
        private void UpdateProgress(int progressPercentage)
        {
            // Update ProgressBar
            progressBar.Value = progressPercentage;
        }

        private int elapsedTime = 0; // Keeps track of the elapsed time in seconds
        private int totalDuration = 60; // Total duration of the task in seconds
        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            progressBar.Value = (int)((double)elapsedTime / totalDuration * 100); // Calculate the progress percentage

            if (elapsedTime >= totalDuration)
            {
                timer1.Stop(); // Stop the timer when the task is complete
                MessageBox.Show("Task completed!");
            }
        }

        private void PopulateRoutesComboBox()
        {
            var routes = _context.Routes
                                 .Select(r => new { r.RouteID, r.Description })
                                 .ToList();

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
        private void InitializeDataGridView()
        {
            // Assuming dataGridViewSeats is your DataGridView control
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("SeatNumber", "Seat Number");
            dataGridView1.Columns.Add("IsOccupied", "Occupied Status");
                        
            // Optionall1t properties for better visual representation
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PopulateSeats(int busId)
        {
            var seats = _context.Seats.Where(s => s.BusID == busId).ToList();

            dataGridView1.Rows.Clear();

            foreach (var seat in seats)
            {
                dataGridView1.Rows.Add(seat.SeatNumber, seat.IsOccupied ? "Occupied" : "Free");
            }
        }
        private void UpdateSeatStatus(int seatId, bool isOccupied)
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
