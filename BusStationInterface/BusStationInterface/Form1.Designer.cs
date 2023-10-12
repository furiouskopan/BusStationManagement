namespace BusStationInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewBuses = new DataGridView();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            driverBindingSource = new BindingSource(components);
            dataGridViewDrivers = new DataGridView();
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactInformationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnEditBus = new Button();
            btnEditDriver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBuses
            // 
            dataGridViewBuses.AccessibleRole = AccessibleRole.None;
            dataGridViewBuses.AllowDrop = true;
            dataGridViewBuses.AllowUserToAddRows = false;
            dataGridViewBuses.AllowUserToDeleteRows = false;
            dataGridViewBuses.AllowUserToResizeColumns = false;
            dataGridViewBuses.AllowUserToResizeRows = false;
            dataGridViewBuses.AutoGenerateColumns = false;
            dataGridViewBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuses.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, busTypeDataGridViewTextBoxColumn, totalSeatsDataGridViewTextBoxColumn });
            dataGridViewBuses.DataSource = busBindingSource;
            dataGridViewBuses.Location = new Point(12, 56);
            dataGridViewBuses.Name = "dataGridViewBuses";
            dataGridViewBuses.RowHeadersVisible = false;
            dataGridViewBuses.RowTemplate.Height = 25;
            dataGridViewBuses.Size = new Size(151, 115);
            dataGridViewBuses.TabIndex = 0;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "ID";
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            busIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            busIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            busTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            busTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            totalSeatsDataGridViewTextBoxColumn.Width = 40;
            // 
            // busBindingSource
            // 
            busBindingSource.DataSource = typeof(Models.Bus);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "All Buses\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 28);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "All Drivers";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.AutoGenerateColumns = false;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn });
            dataGridViewDrivers.DataSource = driverBindingSource;
            dataGridViewDrivers.Location = new Point(197, 57);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.RowTemplate.Height = 25;
            dataGridViewDrivers.Size = new Size(259, 114);
            dataGridViewDrivers.TabIndex = 3;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "ID";
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            contactInformationDataGridViewTextBoxColumn.DataPropertyName = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.HeaderText = "Phone";
            contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            // 
            // btnEditBus
            // 
            btnEditBus.Location = new Point(74, 177);
            btnEditBus.Name = "btnEditBus";
            btnEditBus.Size = new Size(89, 35);
            btnEditBus.TabIndex = 4;
            btnEditBus.Text = "Edit Buses";
            btnEditBus.UseVisualStyleBackColor = true;
            btnEditBus.Click += btnEditBus_Click;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(371, 177);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(85, 35);
            btnEditDriver.TabIndex = 5;
            btnEditDriver.Text = "Edit Drivers";
            btnEditDriver.UseVisualStyleBackColor = true;
            btnEditDriver.Click += btnEditDriver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 586);
            Controls.Add(btnEditDriver);
            Controls.Add(btnEditBus);
            Controls.Add(dataGridViewDrivers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewBuses);
            Name = "Form1";
            Text = "Bus Station";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBuses;
        private BindingSource busBindingSource;
        private Label label1;
        private Label label2;
        private BindingSource driverBindingSource;
        private DataGridView dataGridViewDrivers;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactInformationDataGridViewTextBoxColumn;
        private Button btnEditBus;
        private Button btnEditDriver;
    }
}