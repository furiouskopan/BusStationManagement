using BusStationInterface.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStationInterface.Forms
{
    public partial class RouteDetailsEditForm : Form
    {
        private readonly BusManagementContext _context;
        private readonly int _routeDetailId;

        public RouteDetailsEditForm(dynamic selectedRouteDetail)
        {
            InitializeComponent();
            _context = new BusManagementContext();

            _routeDetailId = selectedRouteDetail.RouteDetailID;

            // Populate the Locations ComboBox
            var locations = _context.Destinations.ToList();
            cmbLocations.DataSource = locations;
            cmbLocations.DisplayMember = "Name";
            cmbLocations.ValueMember = "LocationID";

            // Populate the form fields
            txtRouteDetailID.Text = selectedRouteDetail.RouteDetailID.ToString();
            txtRouteID.Text = selectedRouteDetail.RouteID.ToString();
            cmbLocations.SelectedValue = selectedRouteDetail.LocationID;
            txtSequenceNumber.Text = selectedRouteDetail.SequenceNumber.ToString();
            dateTimePickerTime.Value = DateTime.Parse(selectedRouteDetail.Time);
            txtDescription.Text = selectedRouteDetail.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var routeDetail = _context.RouteDetails.FirstOrDefault(rd => rd.RouteDetailID == _routeDetailId);

                if (routeDetail != null)
                {
                    routeDetail.RouteID = int.Parse(txtRouteID.Text);
                    routeDetail.LocationID = (int)cmbLocations.SelectedValue;
                    routeDetail.SequenceNumber = int.Parse(txtSequenceNumber.Text);
                    routeDetail.Time = dateTimePickerTime.Value.TimeOfDay;
                    routeDetail.Description = txtDescription.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Changes saved successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("RouteDetail not found!");
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

        private void RouteDetailsEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
