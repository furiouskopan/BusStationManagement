using BusStationInterface.Data;
using BusStationInterface.Models;
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
                s.DepartureTime,
                s.EstimatedArrivalTime,

                // Extract names for Start and End Destinations
                StartDestinationName = s.Route.StartDestination.Name,
                EndDestinationName = s.Route.EndDestination.Name,
                DriverName = s.Driver.Name,
                RouteDescription = s.Route.Description,

            }).ToList();

            dgvSchedules.DataSource = schedulesWithDetails;

            dgvSchedules.Columns["Driver"].DataPropertyName = "DriverName";
            dgvSchedules.Columns["Route"].DataPropertyName = "RouteDescription";
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {

            var schedule = new Schedule
            {
                BusID = (int)cmbBus.SelectedValue,
                RouteID = (int)cmbRoute.SelectedValue,
                DriverID = (int)cmbDriver.SelectedValue,
                Day = (DayOfWeek)cmbDay.SelectedValue,
                Status = txtStatus.Text,
                DepartureTime = dtpDepartureTime.Value,
                EstimatedArrivalTime = dtpArrivalTime.Value,
            };

            _context.Schedules.Add(schedule);
            _context.SaveChanges();

            LoadSchedules();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count > 0)
            {
                var scheduleId = (int)dgvSchedules.SelectedRows[0].Cells["ScheduleID"].Value;
                var scheduleToDelete = _context.Schedules.Find(scheduleId);

                if (scheduleToDelete != null)
                {
                    _context.Schedules.Remove(scheduleToDelete);
                    _context.SaveChanges();
                }

                LoadSchedules();
            }
        }

        private void ScheduleEditForm_Load(object sender, EventArgs e)
        {

        }
    }

}
