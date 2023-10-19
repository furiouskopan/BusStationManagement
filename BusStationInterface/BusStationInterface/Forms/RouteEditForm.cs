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
    public partial class RouteEditForm : Form
    {
        private RouteDataAccess _routeDataAccess;
        private Route _selectedRoute;

        public RouteEditForm(RouteDataAccess routeDataAccess)
        {
            InitializeComponent();
            _routeDataAccess = routeDataAccess;
            _selectedRoute = null;
            LoadRoutes();
        }
        private void LoadRoutes()
        {
            var routes = _routeDataAccess.GetRoutes();
            dataGridViewDriversOnEditForm.DataSource = routes;
        }

        private void RouteEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
