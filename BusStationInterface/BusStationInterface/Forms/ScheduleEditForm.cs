using BusStationInterface.Data;
using BusStationInterface.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BusStationInterface.Forms
{
    public partial class ScheduleEditForm : Form
    {
        private BusManagementContext _context = new BusManagementContext();
        public ScheduleEditForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadSchedules();
        }

        private void ScheduleEditForm_Load(object sender, EventArgs e)
        {
            dgvSchedules.Columns["departureTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dgvSchedules.Columns["estimatedArrivalTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dtpArrivalTime.CustomFormat = "HH:mm";
            dtpDepartureTime.CustomFormat = "HH:mm";

            dtpArrivalEdit.CustomFormat = "HH:mm";
            dtpDepartureEdit.CustomFormat = "HH:mm";

            dgvSchedules.AutoGenerateColumns = false;

            InitializeDayComboBox();
        }   

        private void LoadDropdowns()
        {
            using (var context = new BusManagementContext())
            {
                cmbRoute.DataSource = context.Routes.ToList();
                cmbRoute.DisplayMember = "Description";
                cmbRoute.ValueMember = "RouteID";

                cmbDriver.DataSource = context.Drivers.ToList();
                cmbDriver.DisplayMember = "Name";
                cmbDriver.ValueMember = "DriverID";

                cmbBus.DataSource = context.Buses.ToList();
                cmbBus.DisplayMember = "BusID";
                cmbBus.ValueMember = "BusID";

                cmbDay.DataSource = Enum.GetValues(typeof(DayOfWeek));
            }
        }

        private void LoadSchedules(DayOfWeek? selectedDay = null, string locationFilter = null)
        {
            var query = _context.Schedules
                    .Include(s => s.Route)
                    .ThenInclude(r => r.RouteDetails)
                    .ThenInclude(rd => rd.Location)
                    .AsQueryable();

            if (selectedDay.HasValue)
            {
                query = query.Where(s => s.Day == selectedDay.Value);
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                query = query.Where(s => s.Route.StartDestination.Name.Contains(locationFilter) ||
                                         s.Route.EndDestination.Name.Contains(locationFilter) ||
                                         s.Route.RouteDetails.Any(rd => rd.Location.Name.Contains(locationFilter)));
            }

            var schedulesWithDetails = query.Select(s => new
            {
                s.ScheduleID,
                s.BusID,
                s.RouteID,
                s.DriverID,
                s.Status,
                s.Day,
                s.DepartureTime,
                s.EstimatedArrivalTime,
                StartDestinationName = s.StartDestination.Name,
                EndDestinationName = s.EndDestination.Name,
                DriverName = s.Driver.Name,
                RouteDescription = s.Route.Description,
                TotalSeats = s.Bus.TotalSeats,
                OccupiedSeats = s.Tickets.Count(),
                AvailableSeats = s.Bus.TotalSeats - s.Tickets.Count()
            }).ToList();

            dgvSchedules.DataSource = schedulesWithDetails;
            dgvSchedules.AutoGenerateColumns = true;

            dgvSchedules.Columns["TotalSeats"].DataPropertyName = "TotalSeats";
            dgvSchedules.Columns["AvailableSeats"].DataPropertyName = "AvailableSeats";
        }


        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            // Fetch the selected Route from the context to get associated destinations.
            var selectedRouteId = (int)cmbRoute.SelectedValue;
            var selectedRoute = _context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);

            if (selectedRoute == null)
            {
                // Handle this error condition, perhaps show a message to the user.
                MessageBox.Show("Selected route not found.");
                return;
            }

            var schedule = new Schedule
            {
                BusID = (int)cmbBus.SelectedValue,
                RouteID = selectedRouteId,
                DriverID = (int)cmbDriver.SelectedValue,
                Day = (DayOfWeek)cmbDay.SelectedValue,
                Status = txtStatus.Text,
                DepartureTime = dtpDepartureTime.Value,
                EstimatedArrivalTime = dtpArrivalTime.Value,
                StartDestinationId = selectedRoute.StartDestinationID, // Set the StartDestinationId from the Route
                EndDestinationId = selectedRoute.EndDestinationID     // Set the EndDestinationId from the Route
            };

            _context.Schedules.Add(schedule);
            _context.SaveChanges();

            LoadSchedules();
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSchedules.SelectedRows.Count > 0)
                {
                    var scheduleId = (int)dgvSchedules.SelectedRows[0].Cells["scheduleIDDataGridViewTextBoxColumn"].Value;
                    var scheduleToDelete = _context.Schedules.Find(scheduleId);

                    if (scheduleToDelete != null)
                    {
                        _context.Schedules.Remove(scheduleToDelete);
                        _context.SaveChanges();
                    }

                    LoadSchedules();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting schedule: " + ex.Message);
            }

        }
        private void dtpArrivalTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dtpArrivalTime.Value;
        }
        private void InitializeDayComboBox()
        {
            cmbDayEdit.DataSource = Enum.GetValues(typeof(DayOfWeek));
            cmbDayFilter.DataSource = Enum.GetValues(typeof(DayOfWeek));
            cmbDayEdit.SelectedItem = DateTime.Today.DayOfWeek;
            //cmbDayFilter.SelectedItem = DateTime.Today.DayOfWeek;
        }
        private void dataGridViewSchedules_SelectionChanged(object sender, EventArgs e)
        {
            cmbBusEdit.DataSource = _context.Buses.ToList();
            cmbBusEdit.ValueMember = "BusID";
            cmbDriverEdit.DataSource = _context.Drivers.ToList();
            cmbDriverEdit.ValueMember = "DriverID";
            cmbDriverEdit.DisplayMember = "Name";

            if (dgvSchedules.CurrentRow != null)
            {
                // Assuming you have fields for ID, BusID, RouteID, etc.
                cmbBusEdit.SelectedValue = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["busIDDataGridViewTextBoxColumn"].Value);
                cmbDriverEdit.SelectedValue = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["driverIDDataGridViewTextBoxColumn"].Value);
                txtStatusEdit.Text = dgvSchedules.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                dtpDepartureEdit.Value = (DateTime)dgvSchedules.CurrentRow.Cells["departureTimeDataGridViewTextBoxColumn"].Value;
                dtpArrivalEdit.Value = (DateTime)dgvSchedules.CurrentRow.Cells["estimatedArrivalTimeDataGridViewTextBoxColumn"].Value;

                string selectedDayAsString = dgvSchedules.CurrentRow.Cells["dayDataGridViewTextBoxColumn"].Value.ToString();
                if (Enum.TryParse(selectedDayAsString, out DayOfWeek selectedDay))
                {
                    cmbDayEdit.SelectedItem = selectedDay;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input first (check if the entered IDs exist, etc.)

            // Then, if using Entity Framework
            using (var context = new BusManagementContext())
            {
                int scheduleId = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);
                Schedule schedule = context.Schedules.FirstOrDefault(s => s.ScheduleID == scheduleId);

                if (schedule != null)
                {
                    // Update fields
                    schedule.BusID = Convert.ToInt32(cmbBusEdit.SelectedValue);
                    schedule.DriverID = Convert.ToInt32(cmbDriverEdit.SelectedValue);
                    schedule.Status = txtStatusEdit.Text;
                    schedule.DepartureTime = dtpDepartureEdit.Value;
                    schedule.EstimatedArrivalTime = dtpArrivalEdit.Value;
                    if (Enum.TryParse(cmbDayEdit.SelectedItem.ToString(), out DayOfWeek selectedDay))
                    {
                        schedule.Day = selectedDay;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Schedule updated successfully.");
                }
                else
                {
                    MessageBox.Show("Schedule not found.");
                }
            }

            // Refresh your DataGridView to show the updated data
            LoadSchedules();
        }

        // Method to get the number of free seats for a schedule
        public int GetNumberOfFreeSeatsForSchedule(int scheduleId)
        {
            var schedule = _context.Schedules
                .Include(s => s.Bus)
                .ThenInclude(b => b.Seats)
                .Include(s => s.Tickets)
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null) return 0;

            int totalSeats = schedule.Bus.Seats.Count;
            int occupiedSeats = schedule.Tickets.Count(t => t.ScheduleID == scheduleId);

            return totalSeats - occupiedSeats;
        }

        // Method to get all seats and their status for a schedule
        public List<SeatStatus> GetSeatStatusForSchedule(int scheduleId)
        {
            var schedule = _context.Schedules
                .Include(s => s.Bus)
                .ThenInclude(b => b.Seats)
                .Include(s => s.Tickets)
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null) return new List<SeatStatus>();

            var seatStatuses = schedule.Bus.Seats.Select(seat => new SeatStatus
            {
                SeatID = seat.SeatID,
                IsOccupied = schedule.Tickets.Any(ticket => ticket.SeatID == seat.SeatID && ticket.ScheduleID == scheduleId)
            }).ToList();

            return seatStatuses;
        }

        private void ApplyFilters()
        {
            DayOfWeek? selectedDay = cmbDayFilter.SelectedItem as DayOfWeek?;
            string locationFilter = txtLocationFilter.Text.Trim();

            LoadSchedules(selectedDay, locationFilter);
        }
        private void txtLocationFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbDayFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
    public class SeatStatus
    {
        public int SeatID { get; set; }
        public bool IsOccupied { get; set; }
    }
}
