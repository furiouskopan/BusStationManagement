using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusStationInterface.Models;
using OfficeOpenXml;

namespace BusStationInterface.Forms
{
    public partial class TicketReportsForm : Form
    {
        private TicketDataAccess _dataAccessLayer;

        public TicketReportsForm(TicketDataAccess dataAccessLayer)
        {
            InitializeComponent();
            _dataAccessLayer = dataAccessLayer;
        }
        //public TicketReportsForm()
        //{
        //    InitializeComponent();
        //}

        private void TicketReportsForm_Load(object sender, EventArgs e)
        {
            // Initialize your form here, e.g., populate dropdowns
            PopulateRouteComboBox();
        }

        private void PopulateRouteComboBox()
        {
            // Fetch routes and bind them to the ComboBox
            var routes = _dataAccessLayer.GetRoutes();

            // Create a 'Select All' option
            var allRoutesOption = new Route { RouteID = -1, Description = "All Routes" };

            // Add 'Select All' option to the beginning of the list

            routes.Insert(0, allRoutesOption);
            cmbRoute.DataSource = routes;
            cmbRoute.DisplayMember = "Description";
            cmbRoute.ValueMember = "RouteID";
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFrom.Value.Date;
            var toDate = dateTimePickerTo.Value.Date;
            var selectedRouteId = Convert.ToInt32(cmbRoute.SelectedValue);

            if (fromDate > toDate)
            {
                MessageBox.Show("The 'From' date must be earlier than the 'To' date.");
                return;
            }
            GenerateAndDisplayReport(fromDate, toDate, selectedRouteId);
        }

        private void GenerateAndDisplayReport(DateTime fromDate, DateTime toDate, int routeId)
        {
            List<TicketReportItem> reportData;

            // Check if 'All Routes' is selected
            if (routeId == -1)
            {
                // Fetch report data for all routes
                reportData = _dataAccessLayer.GetTicketReport(fromDate, toDate);
            }
            else
            {
                // Fetch report data for a specific route
                reportData = _dataAccessLayer.GetTicketReport(fromDate, toDate, routeId);
            }

            // Bind the report data to the DataGridView
            dataGridViewReports.DataSource = reportData;
        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }

        private void ExportToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.Add("Ticket Report");

                // Add headers
                worksheet.Cells[1, 1].Value = "Ticket ID";
                worksheet.Cells[1, 2].Value = "Bus ID";
                worksheet.Cells[1, 3].Value = "Issue Date";
                worksheet.Cells[1, 4].Value = "Start Destination";
                worksheet.Cells[1, 5].Value = "End Destination";
                worksheet.Cells[1, 6].Value = "Price";
                worksheet.Cells[1, 7].Value = "Issued By";

                // Populate data from DataGridView
                int row = 2;
                foreach (DataGridViewRow dgvRow in dataGridViewReports.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    worksheet.Cells[row, 1].Value = dgvRow.Cells["TicketID"].Value;
                    worksheet.Cells[row, 2].Value = dgvRow.Cells["BusID"].Value;
                    worksheet.Cells[row, 3].Value = Convert.ToDateTime(dgvRow.Cells["IssueDate"].Value).ToOADate(); 
                    worksheet.Cells[row, 3].Style.Numberformat.Format = "mm-dd-yyyy hh:mm"; 
                    worksheet.Cells[row, 4].Value = dgvRow.Cells["StartDestinationName"].Value;
                    worksheet.Cells[row, 5].Value = dgvRow.Cells["EndDestinationName"].Value;
                    worksheet.Cells[row, 6].Value = dgvRow.Cells["Price"].Value;
                    worksheet.Cells[row, 7].Value = dgvRow.Cells["IssuedByEmployeeName"].Value;

                    row++;
                }

                // Save the Excel file
                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
                MessageBox.Show($"Report exported to {filePath}");
            }
        }

    }
}
