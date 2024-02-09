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
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            // Start the simulation
            int selectedScheduleId = (int)cmbRoutes.SelectedValue;
            Task.Run(() => _simulationService.SimulateBusRoute(selectedScheduleId, _cancellationTokenSource.Token));
        }

        private void btnStopSimulation_Click(object sender, EventArgs e)
        {
            // Stop the simulation
            _cancellationTokenSource.Cancel();
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

        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoutes.SelectedValue is int selectedRouteId)
            {
                PopulateSchedulesComboBox(selectedRouteId);
            }
        }
    }
}
