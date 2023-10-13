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

namespace BusStationInterface
{
    public partial class DriverEditForm : Form
    {
        private DriverDataAccess _driverDataAccess;
        private List<Driver> _allDrivers;
        private List<int> _driversToDelete;
        public DriverEditForm(DriverDataAccess driverDataAccess)
        {
            InitializeComponent();
            _driverDataAccess = driverDataAccess;
            _allDrivers = _driverDataAccess.GetDrivers();
            _driversToDelete = new List<int>();

            dataGridViewDriversOnEditForm.DataSource = _allDrivers;
            dataGridViewDriversOnEditForm.RowHeadersVisible = false;
        }
        private void DriverEditForm_Load(object sender, EventArgs e)
        {
            DriverDataAccess driverDataAccess = new DriverDataAccess();
            List<Driver> drivers = driverDataAccess.GetDrivers();

            dataGridViewDriversOnEditForm.DataSource = drivers;
            dataGridViewDriversOnEditForm.RowHeadersVisible = false;
            dataGridViewDriversOnEditForm.ReadOnly = false;
        }

        private void btnSaveDriverEdit_Click(object sender, EventArgs e)
        {
            // Update existing and add new records
            foreach (DataGridViewRow row in dataGridViewDriversOnEditForm.Rows)
            {
                if (row.IsNewRow) continue; // Skip the 'new row' at the end

                Driver driver = new Driver
                {
                    DriverID = Convert.ToInt32(row.Cells["driverIDDataGridViewTextBoxColumn"].Value),
                    Name = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(),
                    ContactInformation = row.Cells["contactInformationDataGridViewTextBoxColumn"].Value.ToString()
                };

                if (driver.DriverID > 0) // Existing record
                {
                    _driverDataAccess.UpdateDriver(driver);
                }
                else // New record
                {
                    _driverDataAccess.AddDriver(driver);
                }
            }

            // Delete queued records
            foreach (int driverID in _driversToDelete)
            {
                _driverDataAccess.DeleteDriver(driverID);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            string driverName = txtDriverName.Text;
            string driverContact = txtDriverContact.Text;

            if (string.IsNullOrWhiteSpace(driverName) || string.IsNullOrWhiteSpace(driverContact))
            {
                MessageBox.Show("Please fill out all the fields.");
                return;
            }

            Driver newDriver = new Driver
            {
                Name = driverName,
                ContactInformation = driverContact
            };

            _allDrivers.Add(newDriver);

            // Refresh the DataGridView
            dataGridViewDriversOnEditForm.DataSource = null;
            dataGridViewDriversOnEditForm.DataSource = _allDrivers;

            // Optionally clear the textboxes
            txtDriverName.Clear();
            txtDriverContact.Clear();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (dataGridViewDriversOnEditForm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDriversOnEditForm.SelectedRows[0];
                int driverID = Convert.ToInt32(selectedRow.Cells["driverIDDataGridViewTextBoxColumn"].Value);

                // Ask for confirmation before queuing deletion
                DialogResult result = MessageBox.Show("This driver will be deleted after saving. Proceed?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Queue up the driver ID for deletion
                    _driversToDelete.Add(driverID);

                    // Remove the driver from the _allDrivers list
                    _allDrivers.RemoveAll(driver => driver.DriverID == driverID);

                    // Refresh the DataGridView to reflect the change
                    dataGridViewDriversOnEditForm.DataSource = null;
                    dataGridViewDriversOnEditForm.DataSource = _allDrivers;
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to delete.");
            }
        }
    }
}
