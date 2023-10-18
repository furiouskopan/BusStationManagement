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

namespace BusStationInterface.Forms
{
    public partial class DestinationEditForm : Form
    {
        private DestinationDataAccess _destinationDataAccess;
        private List<Destination> _allDestinations;
        private List<int> _destinationsToDelete;

        public DestinationEditForm(DestinationDataAccess destinationDataAccess)
        {
            InitializeComponent();
            _destinationDataAccess = destinationDataAccess;
            _allDestinations = _destinationDataAccess.GetDestinations();
            _destinationsToDelete = new List<int>();

            dataGridViewDestinationsOnEditForm.DataSource = _allDestinations;
            dataGridViewDestinationsOnEditForm.RowHeadersVisible = false;
        }
        private void DestinationEditForm_Load(object sender, EventArgs e)
        {
            DestinationDataAccess destinationDataAccess = new DestinationDataAccess();
            List<Destination> destinations = destinationDataAccess.GetDestinations();

            dataGridViewDestinationsOnEditForm.DataSource = destinations;
            dataGridViewDestinationsOnEditForm.RowHeadersVisible = false;
            dataGridViewDestinationsOnEditForm.ReadOnly = false;
        }
        private void btnSaveDestinationEdit_Click(object sender, EventArgs e)
        {
            // Update existing and add new records
            foreach (DataGridViewRow row in dataGridViewDestinationsOnEditForm.Rows)
            {
                if (row.IsNewRow) continue; // Skip the 'new row' at the end

                Destination destination = new Destination
                {
                    DestinationID = Convert.ToInt32(row.Cells["destinationIDDataGridViewTextBoxColumn"].Value),
                    Name = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(),
                    Description = row.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString()
                };

                if (destination.DestinationID > 0) // Existing record
                {
                    _destinationDataAccess.UpdateDestination(destination);
                }
                else // New record
                {
                    _destinationDataAccess.AddDestination(destination);
                }
            }

            // Delete queued records
            foreach (int destinationID in _destinationsToDelete)
            {
                _destinationDataAccess.DeleteDestination(destinationID);
            }

            this.DialogResult = DialogResult.OK;
        }
        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            string destinationName = txtDestinationName.Text;
            string destinationDescription = txtDestinationDescription.Text;

            if (string.IsNullOrWhiteSpace(destinationName) || string.IsNullOrWhiteSpace(destinationDescription))
            {
                MessageBox.Show("Please fill out all the fields.");
                return;
            }

            Destination newDestination = new Destination
            {
                Name = destinationName,
                Description = destinationDescription
            };

            _allDestinations.Add(newDestination);

            // Refresh the DataGridView
            dataGridViewDestinationsOnEditForm.DataSource = null;
            dataGridViewDestinationsOnEditForm.DataSource = _allDestinations;

            // Optionally clear the textboxes
            txtDestinationName.Clear();
            txtDestinationDescription.Clear();
        }
        private void btnDeleteDestination_Click(object sender, EventArgs e)
        {
            if (dataGridViewDestinationsOnEditForm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDestinationsOnEditForm.SelectedRows[0];
                int destinationID = Convert.ToInt32(selectedRow.Cells["destinationIDDataGridViewTextBoxColumn"].Value);

                // Ask for confirmation before queuing deletion
                DialogResult result = MessageBox.Show("This destination will be deleted after saving. Proceed?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Queue up the destination ID for deletion
                    _destinationsToDelete.Add(destinationID);

                    // Remove the destination from the _allDestinations list
                    _allDestinations.RemoveAll(destination => destination.DestinationID == destinationID);

                    // Refresh the DataGridView to reflect the change
                    dataGridViewDestinationsOnEditForm.DataSource = null;
                    dataGridViewDestinationsOnEditForm.DataSource = _allDestinations;
                }
            }
            else
            {
                MessageBox.Show("Please select a destination to delete.");
            }
        }
    }
}