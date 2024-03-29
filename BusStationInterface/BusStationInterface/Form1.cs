using BusStationInterface.Data;
using BusStationInterface.Forms;
using BusStationInterface.Models;
using BusStationInterface.Utilities;
using Microsoft.EntityFrameworkCore;
using MaterialSkin.Controls;
using MaterialSkin;

namespace BusStationInterface
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.DeepOrange200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void EmbedFormInTab(Form formToEmbed, TabPage tabPage)
        {
            formToEmbed.TopLevel = false;
            formToEmbed.FormBorderStyle = FormBorderStyle.None;
            formToEmbed.Dock = DockStyle.Fill;

            tabPage.Controls.Add(formToEmbed);
            tabPage.Tag = formToEmbed;
            formToEmbed.BringToFront();
            formToEmbed.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBuses();
            LoadDrivers();
            LoadDestinations();
            LoadRoutes();
            LoadSchedules();
            timer1.Start();
            dataGridViewRouteDetails.DataSource = null;
            lblEmployee.Text = UserSession.CurrentEmployeeName;
            if (UserSession.CurrentUserRole != "Administrator")
            {
                adminPanel.Visible = false;
                schedulesPanel.Location = new Point(20, 67);
                schedulesPanel.Size = new Size(840, 230);
                materialTabControl1.TabPages.Remove(tabPageBuses);
                materialTabControl1.TabPages.Remove(tabPageDrivers);
                materialTabControl1.TabPages.Remove(tabPageLocations);

            }

            dataGridViewRoutes.ClearSelection();
            dataGridViewBuses.ClearSelection();
            dataGridViewDrivers.ClearSelection();
            dataGridViewDestinations.ClearSelection();
            dataGridViewRouteDetails.ClearSelection();
            dataGridViewSchedules.ClearSelection();
            SetLabelsFont();

            materialTabControl1.SendToBack();

            var ticketReportDataAccessLayer = new TicketDataAccess(new BusManagementContext());
            TicketReportsForm ticketReportsForm = new TicketReportsForm(ticketReportDataAccessLayer);
            EmbedFormInTab(new TicketReportsForm(ticketReportDataAccessLayer), tabPageTicketReports);

            EmbedFormInTab(new TicketForm(), tabPageTicket);
        }
        private void LoadDestinations()
        {
            DestinationDataAccess destinationDataAccess = new DestinationDataAccess();
            List<Destination> destinations = destinationDataAccess.GetDestinations();

            // Populate your user interface controls with the bus data.
            dataGridViewDestinations.DataSource = destinations;
            dataGridViewDestinations.RowHeadersVisible = false;
            dataGridViewDestinations.ReadOnly = true;  // Make it read-only

            EmbedFormInTab(new DestinationEditForm(destinationDataAccess), tabPageLocations);
        }

        private void LoadBuses()
        {
            BusDataAccess busDataAccess = new BusDataAccess();
            List<Bus> buses = busDataAccess.GetBuses();

            // Populate your user interface controls with the bus data.
            dataGridViewBuses.DataSource = buses;
            dataGridViewBuses.RowHeadersVisible = false;
            dataGridViewBuses.ReadOnly = true;  // Make it read-only


            EmbedFormInTab(new BusEditForm(busDataAccess), tabPageBuses);
        }
        private void LoadDrivers()
        {
            DriverDataAccess driverDataAccess = new DriverDataAccess();
            List<Driver> drivers = driverDataAccess.GetDrivers();

            // Populate your user interface controls with the bus data.
            dataGridViewDrivers.DataSource = drivers;
            dataGridViewDrivers.RowHeadersVisible = false;
            dataGridViewDrivers.ReadOnly = true;  // Make it read-only

            EmbedFormInTab(new DriverEditForm(driverDataAccess), tabPageDrivers);
        }

        private void LoadRoutes()
        {
            RouteDataAccess routeDataAccess = new RouteDataAccess();
            List<Route> routes = routeDataAccess.GetRoutes();

            // Ensure the StartDestination and EndDestination are loaded
            if (routes.Any() && routes.First().StartDestination == null)
            {
                using (var context = new BusManagementContext())
                {
                    routes = context.Routes
                        .Include(r => r.StartDestination)
                        .Include(r => r.EndDestination)
                        .ToList();
                }
            }
            var routesWithDestinations = routes.Select(route => new
            {
                route.RouteID,
                StartDestinationId = route.StartDestinationID,
                EndDestinationId = route.EndDestinationID,
                StartDestination = route.StartDestination.Name, 
                EndDestination = route.EndDestination.Name,     
                route.Description
            }).ToList();

            // Populate your user interface controls with the route data including destination information.
            dataGridViewRoutes.DataSource = routesWithDestinations;
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.ReadOnly = true;

            EmbedFormInTab(new RDForm(), tabPageRoutes);
        }
        private void LoadRouteDetails(Route selectedRoute)
        {
            if (selectedRoute == null)
            {
                // Clear or hide the detail view if no route is selected
                dataGridViewRouteDetails.DataSource = null;
            }
            else
            {
                // Use the existing context created in Form1_Load
                using (var context = new BusManagementContext())
                {
                    // Fetch route details based on the selected route with associated Location
                    var routeDetailsWithLocation = context.RouteDetails
                        .Where(rd => rd.RouteID == selectedRoute.RouteID)
                        .Include(rd => rd.Location)
                        .OrderBy(rd => rd.SequenceNumber)
                        .Select(rd => new
                        {
                            rd.RouteDetailID,
                            rd.RouteID,
                            rd.LocationID,
                            LocationName = rd.Location.Name,
                            rd.SequenceNumber,
                            rd.Time,
                            rd.Description
                        })
                        .ToList();

                    // Bind the details with location name to the detail view
                    dataGridViewRouteDetails.DataSource = routeDetailsWithLocation;
                }
                //dataGridViewRouteDetails.Columns["timeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            }
        }
        private void LoadSchedules()
        {
            ScheduleDataAccess scheduleDataAccess = new ScheduleDataAccess();
            List<Schedule> schedules = scheduleDataAccess.GetSchedules();

            // Get today's day
            DayOfWeek today = DateTime.Today.DayOfWeek;

            // Get the location filter from the textbox (assuming the textbox is named txtLocationFilter)
            string locationFilter = txtLocationFilter.Text.Trim();

            var filteredSchedules = schedules.Where(s => s.Day == today &&
                                                         (s.Route.StartDestination.Name.Contains(locationFilter) ||
                                                          s.Route.EndDestination.Name.Contains(locationFilter) ||
                                                          s.Route.RouteDetails.Any(rd => rd.Location.Name.ToLower().Contains(locationFilter.ToLower()) == true)))

                                             .Select(s => new
                                             {
                                                 s.ScheduleID,
                                                 s.BusID,
                                                 s.RouteID,
                                                 s.DriverID,
                                                 s.Status,
                                                 s.Day,
                                                 s.DepartureTime,
                                                 s.EstimatedArrivalTime,
                                                 StartDestinationName = s.Route.StartDestination.Name,
                                                 EndDestinationName = s.Route.EndDestination.Name,
                                                 DriverName = s.Driver.Name,
                                                 RouteDescription = s.Route.Description,
                                             }).ToList();

            dataGridViewSchedules.DataSource = filteredSchedules;

            dataGridViewSchedules.Columns["Driver"].DataPropertyName = "DriverName";
            dataGridViewSchedules.Columns["Route"].DataPropertyName = "RouteDescription";

            dataGridViewSchedules.Columns["estimatedArrivalTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dataGridViewSchedules.Columns["departureTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";


            dataGridViewSchedules.RowHeadersVisible = false;
            dataGridViewSchedules.ReadOnly = true;

            EmbedFormInTab(new ScheduleEditForm(), tabPageSchedules);
        }

        private void dataGridViewRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.SelectedRows.Count > 0)
            {
                // Get the RouteID from the selected row's DataBoundItem
                var selectedItem = dataGridViewRoutes.SelectedRows[0].DataBoundItem as dynamic;
                int selectedRouteId = selectedItem.RouteID;

                // Fetch the Route object using this RouteID
                Route selectedRoute;
                using (var context = new BusManagementContext())
                {
                    selectedRoute = context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);
                }

                // Load and display route details including intermediary stops
                LoadRouteDetails(selectedRoute);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            lblTimer.Font = new Font("Segoe UI", 15, FontStyle.Regular);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.ShowDialog();
        }

        private void txtLocationFilter_TextChanged(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void dataGridViewRouteDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewRouteDetails.Columns[e.ColumnIndex].Name == "timeDataGridViewTextBoxColumn" && e.Value != null)
            {
                e.Value = e.Value.ToString() + " min";
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewBuses_MouseClick(object sender, MouseEventArgs e)
        {
            Point relativePoint = dataGridViewBuses.PointToClient(Cursor.Position);

            // Check if the click is outside of the DataGridView
            if (!dataGridViewBuses.ClientRectangle.Contains(relativePoint))
            {
                // Clear the selection
                dataGridViewBuses.ClearSelection();
            }
        }

        private void dataGridViewRouteDetails_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewRouteDetails.ClearSelection();
        }
        private void dataGridViewBuses_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewBuses.ClearSelection();
        }
        private void dataGridViewDestinations_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDestinations.ClearSelection();
        }
        private void dataGridViewDrivers_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDrivers.ClearSelection();
        }

        private void btnTicketReport_Click(object sender, EventArgs e)
        {
            var dataAccessLayer = new TicketDataAccess(new BusManagementContext());
            TicketReportsForm ticketReportsForm = new TicketReportsForm(dataAccessLayer);
            ticketReportsForm.Show();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 8)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Logout Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void btnSimulation_Click(object sender, EventArgs e)
        {
            BusManagementContext context = new BusManagementContext(); // Ensure this is how you manage contexts across your app
            BusSimulationService simulationService = new BusSimulationService(context);
            SimulationForm simulationForm = new SimulationForm(simulationService, context); // Pass context here
            simulationForm.Show();
        }

        private void btnUpdateScheduleDates_Click(object sender, EventArgs e)
        {
            using (var context = new BusManagementContext())
            {
                ScheduleService scheduleService = new ScheduleService(context);
                scheduleService.UpdateScheduleDatesForNextWeek();
            }
        }
        private void SetLabelsFont()
        {
            Font labelFont = new Font("Segoe UI", 15, FontStyle.Regular);

            label1.Font = labelFont;
            label2.Font = labelFont;
            label3.Font = labelFont;
            label5.Font = labelFont;
            label8.Font = labelFont;
            lblEmployee.Font = labelFont;
        }
    }
}