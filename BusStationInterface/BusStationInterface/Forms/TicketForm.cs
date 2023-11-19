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
using System.Windows.Forms.VisualStyles;

namespace BusStationInterface.Forms
{
    public partial class TicketForm : Form
    {
        private BusManagementContext _context = new BusManagementContext();

        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadSchedules();
            // Optionally, you may want to call the selection changed event here to load seats for the initial selection
            //dataGridViewTicketSchedule_SelectionChanged(this, EventArgs.Empty);
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

            dataGridViewTicketSchedule.DataSource = schedulesWithDetails;
            // Setting AutoGenerateColumns to false is important to manually set which columns to display
            dataGridViewTicketSchedule.AutoGenerateColumns = false;

            // Assuming you've added columns manually in the designer or elsewhere
            // Ensure the Name of the columns corresponds to properties of the anonymous type projected above
            dataGridViewTicketSchedule.Columns["startDestinationDataGridViewTextBoxColumn"].DataPropertyName = "StartDestinationName";
            dataGridViewTicketSchedule.Columns["endDestinationDataGridViewTextBoxColumn"].DataPropertyName = "EndDestinationName";
            dataGridViewTicketSchedule.Columns["driverDataGridViewTextBoxColumn"].DataPropertyName = "DriverName";
            dataGridViewTicketSchedule.Columns["routeDataGridViewTextBoxColumn"].DataPropertyName = "RouteDescription";
            dataGridViewTicketSchedule.Columns["estimatedArrivalTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dataGridViewTicketSchedule.Columns["departureTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
        }

        private void LoadRouteDetails(int routeId)
        {
            var routeDetailsViewModel = _context.RouteDetails
                                                .Where(rd => rd.RouteID == routeId)
                                                .OrderBy(rd => rd.SequenceNumber)
                                                .Include(rd => rd.Location)
                                                .Select(rd => new RouteDetailViewModel
                                                {
                                                    RouteDetailID = rd.RouteDetailID,
                                                    SequenceNumber = rd.SequenceNumber,
                                                    LocationName = rd.Location.Name,
                                                    PriceToNextStop = rd.PriceToNextStop
                                                })
                                                .ToList();

            cmbStartDestination.DataSource = new BindingList<RouteDetailViewModel>(routeDetailsViewModel);
            cmbStartDestination.DisplayMember = "LocationName";
            cmbStartDestination.ValueMember = "RouteDetailID";

            // Create a new list for end destination to avoid sharing the same instance
            cmbEndDestination.DataSource = new BindingList<RouteDetailViewModel>(routeDetailsViewModel.ToList());
            cmbEndDestination.DisplayMember = "LocationName";
            cmbEndDestination.ValueMember = "RouteDetailID";

            if (routeDetailsViewModel.Any())
            {
                cmbEndDestination.SelectedIndex = routeDetailsViewModel.Count - 1;
            }
        }


        // Call this method when a schedule is selected
        private void dataGridViewTicketSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTicketSchedule.CurrentRow != null)
            {
                int scheduleId = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);
                var schedule = _context.Schedules.FirstOrDefault(s => s.ScheduleID == scheduleId);
                if (schedule != null)
                {
                    RefreshAvailableSeats(scheduleId);
                    LoadRouteDetails(schedule.RouteID);
                }
            }
        }

        private void RefreshAvailableSeats(int scheduleId)
        {
            var schedule = _context.Schedules
                .Include(s => s.Bus)
                .Include(s => s.Tickets) // Include tickets to check occupancy for this specific schedule
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule != null)
            {
                // Get all seats for this bus
                var allSeats = _context.Seats
                                       .Where(s => s.BusID == schedule.BusID)
                                       .ToList();

                // Get IDs of seats occupied for this schedule
                var occupiedSeatIds = schedule.Tickets
                                              .Where(t => t.ScheduleID == scheduleId)
                                              .Select(t => t.SeatID)
                                              .ToList();

                // Filter out the occupied seats
                var availableSeats = allSeats
                                     .Where(s => !occupiedSeatIds.Contains(s.SeatID))
                                     .ToList();

                cmbSeat.DataSource = availableSeats;
                cmbSeat.DisplayMember = "SeatNumber";
                cmbSeat.ValueMember = "SeatID";
            }
            else
            {
                MessageBox.Show("The selected schedule is not available.");
                cmbSeat.DataSource = null;
            }
        }

        public decimal CalculatePrice(int startDetailId, int endDetailId)
        {
            // Assuming RouteDetails are ordered by SequenceNumber
            var price = _context.RouteDetails
                                .Where(rd => rd.RouteDetailID >= startDetailId
                                             && rd.RouteDetailID < endDetailId)
                                .Sum(rd => rd.PriceToNextStop);
            return price;
        }
        // Attach this event handler to the SelectedIndexChanged event of both cmbStartDestination and cmbEndDestination.
        private void DestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStartDestination.SelectedItem is RouteDetailViewModel startDetail &&
                cmbEndDestination.SelectedItem is RouteDetailViewModel endDetail)
            {
                // You may want to add additional validation to ensure startDetailId is less than endDetailId
                if (startDetail.RouteDetailID < endDetail.RouteDetailID)
                {
                    var price = CalculatePrice(startDetail.RouteDetailID, endDetail.RouteDetailID);
                    lblPrice.Text = price.ToString() + "MKD";
                }
                else
                {
                    lblPrice.Text = "N/A";
                }
            }
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (cmbSeat.SelectedItem != null && cmbStartDestination.SelectedItem is RouteDetailViewModel startDetailViewModel && cmbEndDestination.SelectedItem is RouteDetailViewModel endDetailViewModel)
            {
                int scheduleId = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);
                int seatId = Convert.ToInt32(cmbSeat.SelectedValue);

                int startDetailId = startDetailViewModel.RouteDetailID;
                int endDetailId = endDetailViewModel.RouteDetailID;

                var price = CalculatePrice(startDetailId, endDetailId);

                var ticket = new Ticket
                {
                    ScheduleID = scheduleId,
                    SeatID = seatId,
                    StartRouteDetailID = startDetailId,
                    EndRouteDetailID = endDetailId,
                    Price = price
                };

                _context.Tickets.Add(ticket);

                // Mark the seat as occupied
                var seat = _context.Seats.FirstOrDefault(s => s.SeatID == seatId);
                if (seat != null)
                {
                    seat.IsOccupied = true;
                }

                _context.SaveChanges();

                // Optionally, add to TicketingLog as well
                var ticketingLog = new TicketingLog
                {
                    TicketID = ticket.TicketID,
                    Timestamp = DateTime.Now
                };

                _context.TicketingLogs.Add(ticketingLog);
                _context.SaveChanges();

                MessageBox.Show("Ticket issued successfully!");

                // Refresh the ComboBox to update the available seats
                RefreshAvailableSeats(scheduleId);

            }
            else
            {
                MessageBox.Show("Please select a seat.");
            }
        }
    }
}
