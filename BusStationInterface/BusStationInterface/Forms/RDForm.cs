using BusStationInterface.Data;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class RDForm : Form
    {
        public RDForm()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is initialized.
        }

        private void LoadData()
        {
            // Load and display routes in the dataGridViewRoutes
            LoadRoutes();
            LoadDestinationsIntoComboBoxes();

            // By default, no route is selected, so load an empty route details DataGridView.
        }
        private void RDForm_Load(object sender, EventArgs e)
        {
            cmbStartDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbStartDestination.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbStartDestination.Text = string.Empty;
            cmbEndDestination.Text = string.Empty;
            cmbDetailLocation.Text = string.Empty;

            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.ReadOnly = false;
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.ReadOnly = false;
        }

        private void LoadRoutes()
        {
            RouteDataAccess routeDataAccess = new RouteDataAccess();
            List<Route> routes = routeDataAccess.GetRoutes();

            // Ensure the StartDestination and EndDestination are loaded
            if (routes.Any() && routes.First().StartDestination == null)
            {
                using (var context = new BusManagementContext())
                {
                    routes = context.Routes
                        .Include(r => r.StartDestination)
                        .Include(r => r.EndDestination)
                        .ToList();
                }
            }
            var routesWithDestinations = routes.Select(route => new
            {
                route.RouteID,
                StartDestinationId = route.StartDestinationID,
                EndDestinationId = route.EndDestinationID,
                StartDestination = route.StartDestination.Name, // Assuming Name is the property of the Destination entity.
                EndDestination = route.EndDestination.Name,     // Assuming Name is the property of the Destination entity.
                route.Description
            }).ToList();

            // Populate your user interface controls with the route data including destination information.
            dataGridViewRoutes.DataSource = routesWithDestinations;
            dataGridViewRoutes.RowHeadersVisible = false;
        }

        private void LoadRouteDetails(Route selectedRoute)
        {
            if (selectedRoute == null)
            {
                // Clear or hide the detail view if no route is selected
                dataGridViewRouteDetails.DataSource = null;
            }
            else
            {
                using (var context = new BusManagementContext())
                {
                    // Fetch route details based on the selected route with associated Location
                    var routeDetailsWithLocation = context.RouteDetails
                        .OrderBy(rd => rd.SequenceNumber)
                        .Where(rd => rd.RouteID == selectedRoute.RouteID)
                        .Include(rd => rd.Location)
                        .Select(rd => new RouteDetailViewModel
                        {
                            RouteDetailID = rd.RouteDetailID,
                            RouteID = rd.RouteID,
                            LocationID = rd.LocationID,
                            LocationName = rd.Location.Name,  // Note the change here
                            SequenceNumber = rd.SequenceNumber,
                            Time = rd.Time,
                            Description = rd.Description
                        })
                        .ToList();

                    // Bind the details with location name to the detail view
                    dataGridViewRouteDetails.DataSource = routeDetailsWithLocation;

                    // Format the DataGridView (customize this as needed):
                    dataGridViewRouteDetails.RowHeadersVisible = false;
                    //dataGridViewRouteDetails.ReadOnly = true;
                }
            }
        }
        private void LoadDestinationsIntoComboBoxes()
        {
            using (var context = new BusManagementContext())
            {
                // Fetch all destinations.
                var destinations = context.Destinations.ToList();

                // Bind to the ComboBoxes.
                cmbStartDestination.DataSource = destinations;
                cmbStartDestination.DisplayMember = "Name";
                cmbStartDestination.ValueMember = "DestinationID";

                cmbEndDestination.DataSource = destinations.ToList(); // Create a new list to separate it from the other combobox.
                cmbEndDestination.DisplayMember = "Name";
                cmbEndDestination.ValueMember = "DestinationID";

                cmbDetailLocation.DataSource = destinations;
                cmbDetailLocation.DisplayMember = "Name";
                cmbDetailLocation.ValueMember = "DestinationID";
            }
        }

        private void dataGridViewRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.SelectedRows.Count > 0)
            {
                // Get the RouteID from the selected row's DataBoundItem
                var selectedItem = dataGridViewRoutes.SelectedRows[0].DataBoundItem as dynamic;
                int selectedRouteId = selectedItem.RouteID;

                // Fetch the Route object using this RouteID
                Route selectedRoute;
                using (var context = new BusManagementContext())
                {
                    selectedRoute = context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);
                }

                // Load and display route details including intermediary stops
                LoadRouteDetails(selectedRoute);
            }
        }


        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            using (var context = new BusManagementContext())
            {
                var newRoute = new Route
                {
                    StartDestinationID = Convert.ToInt32(cmbStartDestination.SelectedValue),
                    EndDestinationID = Convert.ToInt32(cmbEndDestination.SelectedValue),
                    Description = txtDescription.Text
                };
                context.Routes.Add(newRoute);
                context.SaveChanges();
            }
            LoadRoutes();
        }

        private void btnAddRouteDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.SelectedRows.Count > 0)
            {
                var selectedItem = dataGridViewRoutes.SelectedRows[0].DataBoundItem as dynamic;
                int selectedRouteId = selectedItem.RouteID;

                using (var context = new BusManagementContext())
                {
                    TimeSpan timeSpanValue;
                    if (!TimeSpan.TryParse(txtTime.Text, out timeSpanValue))
                    {
                        MessageBox.Show("Please enter a valid time format (e.g., 'hh:mm:ss').");
                        return;
                    }

                    int desiredSequenceNumber = Convert.ToInt32(txtSequenceNumber.Text);

                    var existingDetail = context.RouteDetails.FirstOrDefault(rd => rd.SequenceNumber == desiredSequenceNumber && rd.RouteID == selectedRouteId);

                    if (existingDetail != null)
                    {
                        // Increment sequence numbers of all subsequent route details for the selected route
                        var detailsToUpdate = context.RouteDetails.Where(rd => rd.SequenceNumber >= desiredSequenceNumber && rd.RouteID == selectedRouteId);
                        foreach (var detail in detailsToUpdate)
                        {
                            detail.SequenceNumber++;
                        }
                    }

                    var newRouteDetail = new RouteDetail
                    {
                        RouteID = selectedRouteId,
                        SequenceNumber = desiredSequenceNumber,
                        LocationID = Convert.ToInt32(cmbDetailLocation.SelectedValue),
                        Time = timeSpanValue,
                        Description = txtRouteDetailDescription.Text
                    };
                    context.RouteDetails.Add(newRouteDetail);
                    context.SaveChanges();
                }
                LoadRouteDetails(selectedItem as Route);
            }
        }


        private void btnSaveRoutesEdit_Click(object sender, EventArgs e)
        {
            using (var context = new BusManagementContext())
            {
                foreach (DataGridViewRow row in dataGridViewRouteDetails.Rows)
                {
                    if (row.Cells["RouteDetailID"].Value != null) // Ensure the row is not a new row
                    {
                        int routeDetailId = Convert.ToInt32(row.Cells["RouteDetailID"].Value);
                        RouteDetail existingRouteDetail = context.RouteDetails.Find(routeDetailId);

                        if (existingRouteDetail != null)
                        {
                            // Update properties. You can add more as needed.
                            existingRouteDetail.SequenceNumber = Convert.ToInt32(row.Cells["SequenceNumber"].Value);
                            existingRouteDetail.Time = (TimeSpan)row.Cells["Time"].Value;
                            existingRouteDetail.Description = row.Cells["Description"].Value.ToString();

                            // For properties that are foreign keys or need further validation, ensure
                            // you validate before assigning, to prevent invalid data or exceptions.
                        }
                    }
                }

                // Commit changes to the database.
                context.SaveChanges();
            }
        }
        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.SelectedRows.Count > 0)
            {
                var selectedItem = dataGridViewRoutes.SelectedRows[0].DataBoundItem as dynamic;
                int selectedRouteId = selectedItem.RouteID;

                using (var context = new BusManagementContext())
                {
                    var routeToDelete = context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);
                    if (routeToDelete != null)
                    {
                        context.Routes.Remove(routeToDelete);
                        context.SaveChanges();
                    }
                }
                LoadRoutes();
            }
        }
        private void btnDeleteRouteDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewRouteDetails.SelectedRows.Count > 0)
            {
                var selectedItem = dataGridViewRouteDetails.SelectedRows[0].DataBoundItem as dynamic;
                int selectedRouteDetailId = selectedItem.RouteDetailID;

                using (var context = new BusManagementContext())
                {
                    var routeDetailToDelete = context.RouteDetails.FirstOrDefault(rd => rd.RouteDetailID == selectedRouteDetailId);
                    if (routeDetailToDelete != null)
                    {
                        // Decrement sequence numbers of all subsequent route details for the selected route
                        var detailsToUpdate = context.RouteDetails.Where(rd => rd.SequenceNumber > routeDetailToDelete.SequenceNumber && rd.RouteID == routeDetailToDelete.RouteID);
                        foreach (var detail in detailsToUpdate)
                        {
                            detail.SequenceNumber--;
                        }

                        context.RouteDetails.Remove(routeDetailToDelete);
                        context.SaveChanges();
                    }
                }
                LoadRouteDetails(selectedItem as Route); // Refresh the DataGridView.
            }
        }
    }
}
