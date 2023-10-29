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
    public partial class BusEditForm : Form
    {
        private BusDataAccess _busDataAccess;
        private List<Bus> _allBuses;
        private List<int> _busesToDelete;

        public BusEditForm(BusDataAccess busDataAccess)
        {
            InitializeComponent();

            _busDataAccess = busDataAccess;
            _allBuses = _busDataAccess.GetBuses();
            _busesToDelete = new List<int>();

            dataGridViewBusesOnEditForm.DataSource = _allBuses;
            dataGridViewBusesOnEditForm.RowHeadersVisible = false;
        }
        private void BusEditForm_Load(object sender, EventArgs e)
        {
            BusDataAccess busDataAccess = new BusDataAccess();
            List<Bus> buses = busDataAccess.GetBuses();

            dataGridViewBusesOnEditForm.DataSource = buses;
            dataGridViewBusesOnEditForm.RowHeadersVisible = false;
            dataGridViewBusesOnEditForm.ReadOnly = false;
        }

        private void btnSaveBusEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBusesOnEditForm.Rows)
            {
                if (row.IsNewRow) continue; // Skip the 'new row' at the end

                Bus bus = new Bus
                {
                    BusID = Convert.ToInt32(row.Cells["busIDDataGridViewTextBoxColumn"].Value),
                    BusType = row.Cells["busTypeDataGridViewTextBoxColumn"].Value.ToString(),
                    TotalSeats = Convert.ToInt32(row.Cells["totalSeatsDataGridViewTextBoxColumn"].Value)
                };

                _busDataAccess.UpdateBus(bus);
            }
            foreach (int busID in _busesToDelete)
            {
                _busDataAccess.DeleteBus(busID);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            // 1. Gather input from the textboxes
            string newBusType = txtBusType.Text; // Assuming you have a textbox named txtBusType
            int newTotalSeats;
            if (!int.TryParse(txtTotalSeats.Text, out newTotalSeats)) // Assuming you have a textbox named txtTotalSeats
            {
                MessageBox.Show("Please enter a valid number for total seats.");
                return;
            }

            // 2. Create a new Bus object
            Bus newBus = new Bus
            {
                BusType = newBusType,
                TotalSeats = newTotalSeats
                // Add other properties as needed
            };

            // 3. Add the new Bus object to the database
            _busDataAccess.AddBus(newBus);

            // Optionally:
            // 4. Refresh the data on your DataGridView
            RefreshBusData();

            // Clear the textboxes after adding
            txtBusType.Clear();
            txtTotalSeats.Clear();
        }
        private void RefreshBusData()
        {
            _allBuses = _busDataAccess.GetBuses();
            dataGridViewBusesOnEditForm.DataSource = null;
            dataGridViewBusesOnEditForm.DataSource = _allBuses;
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (dataGridViewBusesOnEditForm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBusesOnEditForm.SelectedRows[0];
                int busID = Convert.ToInt32(selectedRow.Cells["busIDDataGridViewTextBoxColumn"].Value);

                // Ask for confirmation before queuing deletion
                DialogResult result = MessageBox.Show("This bus will be deleted after saving. Proceed?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Queue up the bus ID for deletion
                    _busesToDelete.Add(busID);

                    // Remove the bus from the _allBuses list
                    _allBuses.RemoveAll(bus => bus.BusID == busID);

                    // Refresh the DataGridView to reflect the change
                    dataGridViewBusesOnEditForm.DataSource = null;
                    dataGridViewBusesOnEditForm.DataSource = _allBuses;
                }
            }
            else
            {
                MessageBox.Show("Please select a bus to delete.");
            }
        }
    }
}