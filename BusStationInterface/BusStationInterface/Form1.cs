using BusStationInterface.Data;
using BusStationInterface.Forms;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

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
            using (var context = new BusManagementContext())
            {
                var routes = context.Routes
                    .Include(r => r.StartDestination)
                    .Include(r => r.EndDestination)
                    .Include(r => r.RouteDetails)
                        .ThenInclude(rd => rd.Location)
                    .ToList();
            }
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
            RouteDetailDataAccess routeDetailDataAccess = new RouteDetailDataAccess(); // Create a new instance here

            if (selectedRoute == null)
            {
                // Clear or hide the detail view if no route is selected
                dataGridViewRouteDetails.DataSource = null;
            }
            else
            {
                // Fetch route details based on the selected route
                List<RouteDetail> routeDetails = routeDetailDataAccess.GetRouteDetails(selectedRoute.RouteID);

                // Bind the details to the detail view
                dataGridViewRouteDetails.DataSource = routeDetails;
            }
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

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            RouteDataAccess routeDataAccess = new RouteDataAccess();

            // Create an instance of the edit window and pass the route data access
            RouteEditForm editForm = new RouteEditForm(routeDataAccess);

            // Show the edit window
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload the routes on the main form after editing
                LoadRoutes();
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
    }
}