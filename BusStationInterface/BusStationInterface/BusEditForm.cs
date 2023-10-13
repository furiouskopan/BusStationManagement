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

        public BusEditForm(BusDataAccess busDataAccess)
        {
            InitializeComponent();

            _busDataAccess = busDataAccess;
            _allBuses = _busDataAccess.GetBuses();

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
                    // Add other properties as needed
                };

                _busDataAccess.UpdateBus(bus);
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
    }
}