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

        private void LoadSchedules()
        {
            var schedulesWithDetails = _context.Schedules.Select(s => new
            {
                s.ScheduleID,
                s.BusID,
                s.RouteID,
                s.DriverID,
                s.Status,
                s.Day,
                s.Price,
                s.DepartureTime,
                s.EstimatedArrivalTime,
                StartDestinationName = s.StartDestination.Name,
                EndDestinationName = s.EndDestination.Name,
                DriverName = s.Driver.Name,
                RouteDescription = s.Route.Description,
                TotalSeats = s.Bus.TotalSeats,  // TotalSeats is a property of Bus
                OccupiedSeats = s.Tickets.Count(),  // Assuming a Ticket is created for each occupied seat
                AvailableSeats = s.Bus.TotalSeats - s.Tickets.Count()  // AvailableSeats is TotalSeats minus OccupiedSeats
            }).ToList();

            dgvSchedules.DataSource = schedulesWithDetails;
            dgvSchedules.AutoGenerateColumns = true;

            //dgvSchedules.Columns["Driver"].DataPropertyName = "DriverName";
            //dgvSchedules.Columns["Route"].DataPropertyName = "RouteDescription";

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
                Price = Convert.ToInt32(this.txtPrice.Text),
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

        private void ScheduleEditForm_Load(object sender, EventArgs e)
        {
            dtpArrivalTime.CustomFormat = "HH:mm";
            dtpDepartureTime.CustomFormat = "HH:mm";

            dgvSchedules.Columns["estimatedArrivalTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dgvSchedules.Columns["departureTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
        }
        private void dtpArrivalTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dtpArrivalTime.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
    }
    public class SeatStatus
    {
        public int SeatID { get; set; }
        public bool IsOccupied { get; set; }
    }
}
