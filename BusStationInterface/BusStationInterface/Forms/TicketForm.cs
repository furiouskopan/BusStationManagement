using BusStationInterface.Data;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using BusStationInterface.Utilities;

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
            OnDestinationSelectionChanged();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            // Check if a seat, start, and end destinations are selected by the user
            if (cmbSeat.SelectedItem != null && cmbStartDestination.SelectedItem is RouteDetailViewModel startDetailViewModel && cmbEndDestination.SelectedItem is RouteDetailViewModel endDetailViewModel)
            {
                // Retrieve selected schedule, seat, and route details from the form controls
                int scheduleId = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);
                int seatId = Convert.ToInt32(cmbSeat.SelectedValue);

                int startDetailId = startDetailViewModel.RouteDetailID;
                int endDetailId = endDetailViewModel.RouteDetailID;

                // Fetch the current logged-in employee's ID for ticket auditing
                int employeeId = UserSession.CurrentEmployeeId;

                // Calculate the ticket price based on the start and end destinations
                var price = CalculatePrice(startDetailId, endDetailId);

                // Initialize a new Ticket object with selected and calculated details
                var ticket = new Ticket
                {
                    ScheduleID = scheduleId,
                    SeatID = seatId,
                    StartRouteDetailID = startDetailId,
                    EndRouteDetailID = endDetailId,
                    Price = price,
                };

                // Add the new ticket to the context for database persistence
                _context.Tickets.Add(ticket);

                // Load the schedule from the database to ensure it exists and to get additional details
                var schedule = _context.Schedules.Include(s => s.Route).ThenInclude(r => r.RouteDetails)
                                  .FirstOrDefault(s => s.ScheduleID == scheduleId);
                if (schedule == null)
                {
                    MessageBox.Show("Schedule not found."); // Inform the user if the selected schedule does not exist
                    return;
                }

                // Find the selected seat and mark it as occupied in the database
                var seat = _context.Seats.FirstOrDefault(s => s.SeatID == seatId);
                if (seat != null)
                {
                    seat.IsOccupied = true;
                }

                // Commit the changes to the database
                _context.SaveChanges();

                // Calculate the departure and arrival times for the selected ticket segment
                DateTime segmentDepartureTime = CalculateDepartureTimeForStop(schedule, startDetailId);
                DateTime segmentArrivalTime = CalculateArrivalTimeForStop(schedule, endDetailId);

                // Log the ticket issuance in the TicketingLog for auditing purposes
                var ticketingLog = new TicketingLog
                {
                    TicketID = ticket.TicketID,
                    Timestamp = DateTime.Now,
                    EmployeeID = employeeId
                };

                _context.TicketingLogs.Add(ticketingLog);
                _context.SaveChanges(); // Commit the log entry to the database

                // Ensure the ticket references are properly loaded with their associated locations
                _context.Entry(ticket).Reference(t => t.StartRouteDetail).Query().Include(rd => rd.Location).Load();
                _context.Entry(ticket).Reference(t => t.EndRouteDetail).Query().Include(rd => rd.Location).Load();

                // Generate a PDF ticket for the user with all relevant details and save it
                string pdfFileName = $"Ticket_{ticket.TicketID}.pdf";
                TicketPDFGenerator.CreateTicketPDF(pdfFileName, ticket, segmentDepartureTime, segmentArrivalTime);

                // Notify the user of the successful ticket issuance and PDF generation
                MessageBox.Show("Ticket issued successfully! PDF created at: " + pdfFileName);

                // Refresh the available seats in the ComboBox to reflect the current seat occupancy status
                RefreshAvailableSeats(scheduleId);
            }
            else
            {
                // Prompt the user to select a seat if none is selected
                MessageBox.Show("Please select a seat.");
            }
        }

        public List<Seat> GetAvailableSeatsForSubroute(int scheduleId, int startDetailId, int endDetailId)
        {
            var schedule = _context.Schedules
                                   .Include(s => s.Tickets)
                                   .ThenInclude(t => t.Seat)
                                   .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null) return new List<Seat>();

            // Assuming RouteDetails are ordered by SequenceNumber
            var allSeats = _context.Seats.Where(s => s.BusID == schedule.BusID).ToList();
            var unavailableSeatIds = new HashSet<int>();

            foreach (var ticket in schedule.Tickets)
            {
                if ((ticket.StartRouteDetailID <= startDetailId && ticket.EndRouteDetailID > startDetailId) ||
                    (ticket.StartRouteDetailID < endDetailId && ticket.EndRouteDetailID >= endDetailId))
                {
                    unavailableSeatIds.Add(ticket.SeatID.Value);
                }
            }

            return allSeats.Where(s => !unavailableSeatIds.Contains(s.SeatID)).ToList();
        }
        public bool IsSeatAvailable(int seatId, int startDetailId, int endDetailId, int scheduleId)
        {
            // Fetch all tickets for the schedule that involve the seat
            var ticketsForSeat = _context.Tickets
                .Where(t => t.ScheduleID == scheduleId && t.SeatID == seatId)
                .ToList();

            // Check each ticket to see if the seat is occupied for the desired segment
            foreach (var ticket in ticketsForSeat)
            {
                // If the ticket's route segment overlaps with the desired segment, seat is not available
                if ((ticket.StartRouteDetailID < endDetailId && ticket.EndRouteDetailID > startDetailId))
                {
                    return false; // Seat is occupied in the desired segment
                }
            }

            return true; // Seat is available
        }
        public DateTime CalculateDepartureTimeForStop(Schedule schedule, int startStopId)
        {
            DateTime departureTime = schedule.DepartureTime;
            int cumulativeTime = 0;

            foreach (var detail in schedule.Route.RouteDetails.OrderBy(rd => rd.SequenceNumber))
            {
                if (detail.RouteDetailID == startStopId)
                    break;

                cumulativeTime += detail.Time;
            }

            return departureTime.AddMinutes(cumulativeTime);
        }

        public DateTime CalculateArrivalTimeForStop(Schedule schedule, int endStopId)
        {
            DateTime departureTime = schedule.DepartureTime;
            int cumulativeTime = 0;

            foreach (var detail in schedule.Route.RouteDetails.OrderBy(rd => rd.SequenceNumber))
            {
                cumulativeTime += detail.Time;
                if (detail.RouteDetailID == endStopId)
                    break;
            }

            return departureTime.AddMinutes(cumulativeTime);
        }
        public class TicketPDFGenerator
        {
            public static void CreateTicketPDF(string fileName, Ticket ticket, DateTime segmentDepartureTime, DateTime segmentArrivalTime)
            {
                float customWidth = 300;
                float customHeight = 600;

                iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(customWidth, customHeight);

                Document document = new Document(pageSize);
                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                document.Open();

                //var departureTime = ticket.Schedule.DepartureTime;
                //var arrivalTime = ticket.Schedule.EstimatedArrivalTime;

                var startDestinationName = ticket.StartRouteDetail?.Location?.Name ?? "Unknown";
                var endDestinationName = ticket.EndRouteDetail?.Location?.Name ?? "Unknown";

                // Add ticket information to the PDF
                document.Add(new Paragraph($"Ticket ID: {ticket.TicketID}"));
                document.Add(new Paragraph($"{ticket.Seat?.SeatNumber ?? "N/A"}"));
                document.Add(new Paragraph($"Start Destination: {startDestinationName}"));
                document.Add(new Paragraph($"End Destination: {endDestinationName}"));
                document.Add(new Paragraph($"Departure Time: {segmentDepartureTime.ToString("g")}"));
                document.Add(new Paragraph($"Arrival Time: {segmentArrivalTime.ToString("g")}"));
                document.Add(new Paragraph($"Price: {ticket.Price}MKD"));
                document.Add(new Paragraph($"Safe travels!"));

                document.Close();
            }
        }

        private void OnDestinationSelectionChanged()
        {
            if (dataGridViewTicketSchedule.CurrentRow != null)
            {
                int scheduleId = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);
                if (cmbStartDestination.SelectedItem is RouteDetailViewModel startDetailViewModel &&
                    cmbEndDestination.SelectedItem is RouteDetailViewModel endDetailViewModel)
                {
                    var availableSeats = GetAvailableSeatsForSubroute(scheduleId, startDetailViewModel.RouteDetailID, endDetailViewModel.RouteDetailID);
                    cmbSeat.DataSource = availableSeats;
                    cmbSeat.DisplayMember = "SeatNumber";
                    cmbSeat.ValueMember = "SeatID";
                }
            }
        }
    }
}