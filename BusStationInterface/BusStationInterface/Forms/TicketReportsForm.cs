using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace BusStationInterface.Forms
{
    public partial class TicketReportsForm : Form
    {
        private TicketDataAccess _dataAccessLayer;

        internal TicketReportsForm(TicketDataAccess dataAccessLayer)
        {
            InitializeComponent();
            _dataAccessLayer = dataAccessLayer;
        }

        private void TicketReportsForm_Load(object sender, EventArgs e)
        {
            // Initialize your form here, e.g., populate dropdowns
            PopulateRouteComboBox();
        }

        private void PopulateRouteComboBox()
        {
            // Fetch routes and bind them to the ComboBox
            var routes = _dataAccessLayer.GetRoutes();
            cmbRoute.DataSource = routes;
            cmbRoute.DisplayMember = "RouteName";
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
            var reportData = _dataAccessLayer.GetTicketReport(fromDate, toDate);
            dataGridViewReports.DataSource = reportData;

            // Bind the report data to the DataGridView
            dataGridViewReports.DataSource = reportData;

            // Format the DataGridView as needed (e.g., setting column headers)
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
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ticket Report");

                // Add headers
                worksheet.Cells[1, 1].Value = "Ticket ID";
                worksheet.Cells[1, 2].Value = "Departure Time";
                // Add other header fields as needed

                // Populate data from DataGridView
                int row = 2;
                foreach (DataGridViewRow dgvRow in dataGridViewReports.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    worksheet.Cells[row, 1].Value = dgvRow.Cells["TicketID"].Value;
                    worksheet.Cells[row, 2].Value = dgvRow.Cells["DepartureTime"].Value;
                    // Add other fields as needed
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
