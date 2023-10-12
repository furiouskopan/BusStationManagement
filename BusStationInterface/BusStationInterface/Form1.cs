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
    }
}
