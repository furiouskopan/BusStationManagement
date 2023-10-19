using BusStationInterface.Forms;
using BusStationInterface.Models;
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

            // Populate your user interface controls with the route data.
            dataGridViewRoutes.DataSource = routes;
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.ReadOnly = true;  // Make it read-only
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
    }
}
