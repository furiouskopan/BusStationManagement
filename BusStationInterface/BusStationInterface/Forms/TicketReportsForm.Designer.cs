namespace BusStationInterface.Forms
{
    partial class TicketReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerateReport = new MaterialSkin.Controls.MaterialButton();
            btnExportToExcel = new MaterialSkin.Controls.MaterialButton();
            dataGridViewReports = new DataGridView();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            cmbRoute = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.AutoSize = false;
            btnGenerateReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerateReport.Depth = 0;
            btnGenerateReport.HighEmphasis = true;
            btnGenerateReport.Icon = null;
            btnGenerateReport.Location = new Point(34, 439);
            btnGenerateReport.Margin = new Padding(4, 6, 4, 6);
            btnGenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.NoAccentTextColor = Color.Empty;
            btnGenerateReport.Size = new Size(178, 36);
            btnGenerateReport.TabIndex = 0;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerateReport.UseAccentColor = false;
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.AutoSize = false;
            btnExportToExcel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportToExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportToExcel.Depth = 0;
            btnExportToExcel.HighEmphasis = true;
            btnExportToExcel.Icon = null;
            btnExportToExcel.Location = new Point(773, 439);
            btnExportToExcel.Margin = new Padding(4, 6, 4, 6);
            btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.NoAccentTextColor = Color.Empty;
            btnExportToExcel.Size = new Size(178, 36);
            btnExportToExcel.TabIndex = 1;
            btnExportToExcel.Text = "export";
            btnExportToExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExportToExcel.UseAccentColor = false;
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(34, 185);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowTemplate.Height = 25;
            dataGridViewReports.Size = new Size(917, 245);
            dataGridViewReports.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFrom.Location = new Point(34, 147);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(200, 23);
            dateTimePickerFrom.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTo.Location = new Point(751, 147);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(200, 23);
            dateTimePickerTo.TabIndex = 4;
            // 
            // cmbRoute
            // 
            cmbRoute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(442, 146);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(121, 28);
            cmbRoute.TabIndex = 5;
            // 
            // TicketReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 575);
            Controls.Add(cmbRoute);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(dataGridViewReports);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnGenerateReport);
            Name = "TicketReportsForm";
            Text = "TicketReportsForm";
            Load += TicketReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnGenerateReport;
        private MaterialSkin.Controls.MaterialButton btnExportToExcel;
        private DataGridView dataGridViewReports;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private ComboBox cmbRoute;
    }
}