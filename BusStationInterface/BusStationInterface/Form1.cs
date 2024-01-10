using BusStationInterface.Data;
using BusStationInterface.Forms;
using BusStationInterface.Models;
using BusStationInterface.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BusStationInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
            label9.Text = UserSession.CurrentEmployeeName;
            // Check if the user is not an admin
            //if (UserSession.CurrentUserRole != "Administrator")
            //{
            //    adminPanel.Visible = false;
            //    schedulesPanel.Location = new Point(20, 67);
            //    schedulesPanel.Size = new Size(840, 230);
            //    dataGridViewSchedules.Size = new Size(800, 200);
            //    btnTicket.Location = new Point(827, 326);
            //    Size = new Size(934, 652);
            //    lblTimer.ForeColor = Color.White;
            //}

            dataGridViewRoutes.ClearSelection();
            dataGridViewBuses.ClearSelection();
            dataGridViewDrivers.ClearSelection();
            dataGridViewDestinations.ClearSelection();
            dataGridViewRouteDetails.ClearSelection();
            dataGridViewSchedules.ClearSelection();
        }
        private void LoadDestinations()
        {
            DestinationDataAccess destinationDataAccess = new DestinationDataAccess();
            List<Destination> destinations = destinationDataAccess.GetDestinations();

            // Populate your user interface controls with the bus data.
            dataGridViewDestinations.DataSource = destinations;
            dataGridViewDestinations.RowHeadersVisible = false;
            dataGridViewDestinations.ReadOnly = true;  // Make it read-only
        }

        private void LoadBuses()
        {
            BusDataAccess busDataAccess = new BusDataAccess();
            List<Bus> buses = busDataAccess.GetBuses();

            // Populate your user interface controls with the bus data.
            dataGridViewBuses.DataSource = buses;
            dataGridViewBuses.RowHeadersVisible = false;
            dataGridViewBuses.ReadOnly = true;  // Make it read-only
        }
        private void LoadDrivers()
        {
            DriverDataAccess driverDataAccess = new DriverDataAccess();
            List<Driver> drivers = driverDataAccess.GetDrivers();

            // Populate your user interface controls with the bus data.
            dataGridViewDrivers.DataSource = drivers;
            dataGridViewDrivers.RowHeadersVisible = false;
            dataGridViewDrivers.ReadOnly = true;  // Make it read-only
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
                StartDestination = route.StartDestination.Name, // Assuming Name is the property of the Destination entity.
                EndDestination = route.EndDestination.Name,     // Assuming Name is the property of the Destination entity.
                route.Description
            }).ToList();

            // Populate your user interface controls with the route data including destination information.
            dataGridViewRoutes.DataSource = routesWithDestinations;
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.ReadOnly = true;
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
                            LocationName = rd.Location.Name,  // This will now work because Location is loaded
                            rd.SequenceNumber,
                            Time = rd.Time.ToString(@"hh\:mm"),
                            rd.Description
                        })
                        .ToList();

                    // Bind the details with location name to the detail view
                    dataGridViewRouteDetails.DataSource = routeDetailsWithLocation;
                }
                dataGridViewRouteDetails.Columns["timeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            }
        }
        private void LoadSchedules()
        {
            ScheduleDataAccess scheduleDataAccess = new ScheduleDataAccess();
            List<Schedule> schedules = scheduleDataAccess.GetSchedules();

            var schedulesWithDetails = schedules.Select(s => new
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

            dataGridViewSchedules.DataSource = schedulesWithDetails;

            //dataGridViewSchedules.Columns["StartDestination"].DataPropertyName = "StartDestinationName";
            //dataGridViewSchedules.Columns["EndDestination"].DataPropertyName = "EndDestinationName";
            dataGridViewSchedules.Columns["Driver"].DataPropertyName = "DriverName";
            dataGridViewSchedules.Columns["Route"].DataPropertyName = "RouteDescription";

            dataGridViewSchedules.Columns["estimatedArrivalTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";
            dataGridViewSchedules.Columns["departureTimeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "HH:mm";


            dataGridViewSchedules.RowHeadersVisible = false;
            dataGridViewSchedules.ReadOnly = true;
        }

        private void btnEditBus_Click(object sender, EventArgs e)
        {
            // Create an instance of BusDataAccess to pass to the edit form
            BusDataAccess busDataAccess = new BusDataAccess();

            // Create an instance of the edit window and pass the bus data access
            BusEditForm editForm = new BusEditForm(busDataAccess);

            // Show the edit window
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload the buses on the main form after editing
                LoadBuses();
            }
        }
        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            // Create an instance of BusDataAccess to pass to the edit form
            DriverDataAccess driverDataAccess = new DriverDataAccess();

            // Create an instance of the edit window and pass the bus data access
            DriverEditForm editForm = new DriverEditForm(driverDataAccess);

            // Show the edit window
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload the buses on the main form after editing
                LoadDrivers();
            }
        }

        private void btnEditDestinations_Click(object sender, EventArgs e)
        {
            // Create an instance of BusDataAccess to pass to the edit form
            DestinationDataAccess destinationDataAccess = new DestinationDataAccess();

            // Create an instance of the edit window and pass the bus data access
            DestinationEditForm editForm = new DestinationEditForm(destinationDataAccess);

            // Show the edit window
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload the buses on the main form after editing
                LoadDestinations();
            }
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
        private void btnEditRD_Click(object sender, EventArgs e)
        {
            RDForm rdForm = new RDForm();
            rdForm.ShowDialog();
            LoadRoutes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void btnEditSchedules_Click(object sender, EventArgs e)
        {
            ScheduleEditForm schEditForm = new ScheduleEditForm();
            schEditForm.ShowDialog();
            LoadSchedules();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.ShowDialog();
        }
    }
}