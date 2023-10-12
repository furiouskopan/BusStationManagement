namespace BusStationInterface
{
    partial class BusEditForm
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
            components = new System.ComponentModel.Container();
            btnSaveBusEdit = new Button();
            dataGridViewBusesOnEditForm = new DataGridView();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            seatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            schedulesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busLocationLogsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSaveBusEdit
            // 
            btnSaveBusEdit.Location = new Point(152, 220);
            btnSaveBusEdit.Name = "btnSaveBusEdit";
            btnSaveBusEdit.Size = new Size(82, 26);
            btnSaveBusEdit.TabIndex = 6;
            btnSaveBusEdit.Text = "Save";
            btnSaveBusEdit.UseVisualStyleBackColor = true;
            btnSaveBusEdit.Click += btnSaveBusEdit_Click;
            // 
            // dataGridViewBusesOnEditForm
            // 
            dataGridViewBusesOnEditForm.AutoGenerateColumns = false;
            dataGridViewBusesOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusesOnEditForm.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, busTypeDataGridViewTextBoxColumn, totalSeatsDataGridViewTextBoxColumn, seatsDataGridViewTextBoxColumn, schedulesDataGridViewTextBoxColumn, busLocationLogsDataGridViewTextBoxColumn });
            dataGridViewBusesOnEditForm.DataSource = busBindingSource;
            dataGridViewBusesOnEditForm.Location = new Point(73, 64);
            dataGridViewBusesOnEditForm.Name = "dataGridViewBusesOnEditForm";
            dataGridViewBusesOnEditForm.RowTemplate.Height = 25;
            dataGridViewBusesOnEditForm.Size = new Size(240, 150);
            dataGridViewBusesOnEditForm.TabIndex = 7;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "BusID";
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            busTypeDataGridViewTextBoxColumn.HeaderText = "BusType";
            busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            // 
            // busLocationLogsDataGridViewTextBoxColumn
            // 
            busLocationLogsDataGridViewTextBoxColumn.DataPropertyName = "BusLocationLogs";
            busLocationLogsDataGridViewTextBoxColumn.HeaderText = "BusLocationLogs";
            busLocationLogsDataGridViewTextBoxColumn.Name = "busLocationLogsDataGridViewTextBoxColumn";
            // 
            // busBindingSource
            // 
            busBindingSource.DataSource = typeof(Models.Bus);
            // 
            // BusEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 437);
            Controls.Add(dataGridViewBusesOnEditForm);
            Controls.Add(btnSaveBusEdit);
            Name = "BusEditForm";
            Text = "BusEditForm";
            Load += BusEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSaveBusEdit;
        private DataGridView dataGridViewBusesOnEditForm;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busLocationLogsDataGridViewTextBoxColumn;
        private BindingSource busBindingSource;
    }
}