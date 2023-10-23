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
            EnableUserEdits();
        }

        private void LoadData()
        {
            // Load and display routes in the dataGridViewRoutes
            LoadRoutes();

            // By default, no route is selected, so load an empty route details DataGridView.
            //dataGridViewRouteDetails.DataSource = null;
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
            dataGridViewRoutes.ReadOnly = true;
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
                        .Where(rd => rd.RouteID == selectedRoute.RouteID)
                        .Include(rd => rd.Location)
                        .Select(rd => new
                        {
                            rd.RouteDetailID,
                            rd.RouteID,
                            rd.LocationID,
                            LocationName = rd.Location.Name,
                            rd.SequenceNumber,
                            rd.Time,
                            rd.Description
                        })
                        .ToList();

                    // Bind the details with location name to the detail view
                    dataGridViewRouteDetails.DataSource = routeDetailsWithLocation;

                    // Format the DataGridView (customize this as needed):
                    dataGridViewRouteDetails.RowHeadersVisible = false;
                    dataGridViewRouteDetails.ReadOnly = true;
                }
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
                    StartDestinationID = Convert.ToInt32(txtStartDestination.Text), // Assuming this is an ID. If not, some lookup may be needed.
                    EndDestinationID = Convert.ToInt32(txtEndDestination.Text),     // Similarly here.
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
                        // Handle invalid time format
                        MessageBox.Show("Please enter a valid time format (e.g., 'hh:mm:ss').");
                        return;
                    }

                    var newRouteDetail = new RouteDetail
                    {
                        RouteID = selectedRouteId,
                        SequenceNumber = Convert.ToInt32(txtSequenceNumber.Text),
                        LocationID = Convert.ToInt32(txtLocation.Text),  // Assuming this is an ID. If not, some lookup may be needed.
                        Time = timeSpanValue,
                        Description = txtRouteDetailDescription.Text
                    };
                    context.RouteDetails.Add(newRouteDetail);
                    context.SaveChanges();
                }
                LoadRouteDetails(selectedItem as Route); // Refresh the route details.
            }
        }

    private void btnSaveRoutesEdit_Click(object sender, EventArgs e)
        {
            LoadRoutes();
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
        private void RDForm_Load(object sender, EventArgs e)
        {
            dataGridViewRoutes.ReadOnly = false;
            dataGridViewRouteDetails.ReadOnly = false;
        }

        private void EnableUserEdits()
        {
            // Set the DataGridView's EditMode property to allow user edits
            dataGridViewRoutes.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewRouteDetails.EditMode = DataGridViewEditMode.EditOnEnter;
        }
    }
}
