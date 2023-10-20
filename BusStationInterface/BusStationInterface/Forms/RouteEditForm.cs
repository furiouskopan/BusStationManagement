using BusStationInterface.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStationInterface.Forms
{
    public partial class RouteEditForm : Form
    {
        private readonly BusManagementContext _context;
        private readonly int _routeId;

        public RouteEditForm(dynamic selectedRoute)
        {
            InitializeComponent();
            _context = new BusManagementContext();

            _routeId = selectedRoute.RouteID;

            // Populate the Destinations ComboBox for Start and End destinations
            var destinations = _context.Destinations.ToList();
            cmbStartDestinations.DataSource = destinations;
            cmbStartDestinations.DisplayMember = "Name";
            cmbStartDestinations.ValueMember = "DestinationID";

            cmbEndDestinations.DataSource = destinations.ToList(); // Cloning the list to make sure both comboboxes are independent
            cmbEndDestinations.DisplayMember = "Name";
            cmbEndDestinations.ValueMember = "DestinationID";

            // Populate the form fields
            txtRouteID.Text = selectedRoute.RouteID.ToString();
            cmbStartDestinations.SelectedValue = selectedRoute.StartDestinationID;
            cmbEndDestinations.SelectedValue = selectedRoute.EndDestinationID;
            txtDescription.Text = selectedRoute.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var route = _context.Routes.FirstOrDefault(r => r.RouteID == _routeId);

                if (route != null)
                {
                    route.StartDestinationID = (int)cmbStartDestinations.SelectedValue;
                    route.EndDestinationID = (int)cmbEndDestinations.SelectedValue;
                    route.Description = txtDescription.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Changes saved successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Route not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
