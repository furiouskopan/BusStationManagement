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
    }
}