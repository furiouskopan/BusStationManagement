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
            dataGridViewBuses.Rows[1].Selected = true;

            // Check if a row is selected in the DataGridView
            if (dataGridViewBuses.SelectedRows.Count > 0)
            {
                // Retrieve the selected row
                DataGridViewRow selectedRow = dataGridViewBuses.SelectedRows[0];

                // Extract data from the selected row
                int busID = Convert.ToInt32(selectedRow.Cells["busIDDataGridViewTextBoxColumn"].Value);
                string busType = selectedRow.Cells["busTypeDataGridViewTextBoxColumn"].Value.ToString(); // Replace "OtherData" with other column names
                int totalSeats = (int)selectedRow.Cells["totalSeatsDataGridViewTextBoxColumn"].Value;

                // Create an instance of the edit window and pass the data
                BusDataAccess busDataAccess = new BusDataAccess();
                BusEditForm editForm = new BusEditForm(busID, busType, totalSeats, busDataAccess); // Modify the constructor parameters accordingly
                editForm.SelectedRow = selectedRow;

                // Show the edit window
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
    }
}
