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
        public DriverEditForm(DriverDataAccess driverDataAccess)
        {
            InitializeComponent();
            _driverDataAccess = driverDataAccess;
            _allDrivers = _driverDataAccess.GetDrivers();

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
            foreach (DataGridViewRow row in dataGridViewDriversOnEditForm.Rows)
            {
                if (row.IsNewRow) continue; // Skip the 'new row' at the end

                Driver driver = new Driver
                {
                    DriverID = Convert.ToInt32(row.Cells["driverIDDataGridViewTextBoxColumn"].Value),
                    Name = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(),
                    ContactInformation = row.Cells["contactInformationDataGridViewTextBoxColumn"].Value.ToString()
                };

                _driverDataAccess.UpdateDriver(driver);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
