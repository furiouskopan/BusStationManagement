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
        }

        private void LoadSchedules()
        {
            var schedules = _context.Schedules.ToList();
            dataGridViewTicketSchedule.DataSource = schedules;
        }

        private void dataGridViewTicketSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTicketSchedule.CurrentRow != null)
            {
                int scheduleId = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value);

                var availableSeats = _context.Seats.Where(s => s.BusID == scheduleId && s.Ticket == null).ToList();

                // Assuming you have a ComboBox named 'comboBoxSeat' for seat selection
                cmbSeat.DataSource = availableSeats;
                cmbSeat.DisplayMember = "SeatNumber"; // Assuming Seat has a property named 'SeatNumber'
                cmbSeat.ValueMember = "SeatID";
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (cmbSeat.SelectedItem != null)
            {
                var ticket = new Ticket
                {
                    ScheduleID = Convert.ToInt32(dataGridViewTicketSchedule.CurrentRow.Cells["scheduleIDDataGridViewTextBoxColumn"].Value),
                    SeatID = Convert.ToInt32(cmbSeat.SelectedValue)
                };

                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                // Optionally, add to TicketingLog as well
                var ticketingLog = new TicketingLog
                {
                    TicketID = ticket.TicketID,
                    EmployeeID = 1, // You'll need a mechanism to get the current employee's ID
                    Timestamp = DateTime.Now
                };

                _context.TicketingLogs.Add(ticketingLog);
                _context.SaveChanges();

                MessageBox.Show("Ticket issued successfully!");
            }
            else
            {
                MessageBox.Show("Please select a seat.");
            }
        }
    }
}
