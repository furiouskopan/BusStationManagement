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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewDestinations = new DataGridView();
            destinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationBindingSource = new BindingSource(components);
            label3 = new Label();
            btnEditDestinations = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            routeBindingSource = new BindingSource(components);
            routeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            schedulesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeDetailsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnSearchRoute = new Button();
            btnEditRoute = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).BeginInit();
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
            dataGridViewBuses.Location = new Point(41, 76);
            dataGridViewBuses.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBuses.Name = "dataGridViewBuses";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBuses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBuses.RowHeadersVisible = false;
            dataGridViewBuses.RowHeadersWidth = 51;
            dataGridViewBuses.RowTemplate.Height = 25;
            dataGridViewBuses.Size = new Size(173, 200);
            dataGridViewBuses.TabIndex = 0;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "ID";
            busIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            busIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            busIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            busTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            busTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            busTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            totalSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
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
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 1;
            label1.Text = "All Buses\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 40);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 2;
            label2.Text = "All Drivers";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.AllowUserToResizeColumns = false;
            dataGridViewDrivers.AllowUserToResizeRows = false;
            dataGridViewDrivers.AutoGenerateColumns = false;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn });
            dataGridViewDrivers.DataSource = driverBindingSource;
            dataGridViewDrivers.Location = new Point(281, 77);
            dataGridViewDrivers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.RowTemplate.Height = 25;
            dataGridViewDrivers.ScrollBars = ScrollBars.Vertical;
            dataGridViewDrivers.Size = new Size(312, 199);
            dataGridViewDrivers.TabIndex = 3;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "ID";
            driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            contactInformationDataGridViewTextBoxColumn.DataPropertyName = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.HeaderText = "Phone";
            contactInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            contactInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnEditBus
            // 
            btnEditBus.Location = new Point(111, 284);
            btnEditBus.Margin = new Padding(3, 4, 3, 4);
            btnEditBus.Name = "btnEditBus";
            btnEditBus.Size = new Size(103, 53);
            btnEditBus.TabIndex = 4;
            btnEditBus.Text = "Edit Buses";
            btnEditBus.UseVisualStyleBackColor = true;
            btnEditBus.Click += btnEditBus_Click;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(490, 284);
            btnEditDriver.Margin = new Padding(3, 4, 3, 4);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(103, 53);
            btnEditDriver.TabIndex = 5;
            btnEditDriver.Text = "Edit Drivers";
            btnEditDriver.UseVisualStyleBackColor = true;
            btnEditDriver.Click += btnEditDriver_Click;
            // 
            // dataGridViewDestinations
            // 
            dataGridViewDestinations.AllowUserToAddRows = false;
            dataGridViewDestinations.AllowUserToDeleteRows = false;
            dataGridViewDestinations.AllowUserToResizeColumns = false;
            dataGridViewDestinations.AllowUserToResizeRows = false;
            dataGridViewDestinations.AutoGenerateColumns = false;
            dataGridViewDestinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinations.Columns.AddRange(new DataGridViewColumn[] { destinationIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn });
            dataGridViewDestinations.DataSource = destinationBindingSource;
            dataGridViewDestinations.Location = new Point(643, 81);
            dataGridViewDestinations.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDestinations.Name = "dataGridViewDestinations";
            dataGridViewDestinations.ReadOnly = true;
            dataGridViewDestinations.RowHeadersWidth = 51;
            dataGridViewDestinations.RowTemplate.Height = 25;
            dataGridViewDestinations.Size = new Size(426, 200);
            dataGridViewDestinations.TabIndex = 6;
            // 
            // destinationIDDataGridViewTextBoxColumn
            // 
            destinationIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationID";
            destinationIDDataGridViewTextBoxColumn.HeaderText = "ID";
            destinationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            destinationIDDataGridViewTextBoxColumn.Name = "destinationIDDataGridViewTextBoxColumn";
            destinationIDDataGridViewTextBoxColumn.ReadOnly = true;
            destinationIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationBindingSource
            // 
            destinationBindingSource.DataSource = typeof(Models.Destination);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(643, 41);
            label3.Name = "label3";
            label3.Size = new Size(212, 34);
            label3.TabIndex = 7;
            label3.Text = "All Destinations";
            // 
            // btnEditDestinations
            // 
            btnEditDestinations.Location = new Point(951, 289);
            btnEditDestinations.Margin = new Padding(3, 4, 3, 4);
            btnEditDestinations.Name = "btnEditDestinations";
            btnEditDestinations.Size = new Size(119, 53);
            btnEditDestinations.TabIndex = 8;
            btnEditDestinations.Text = "Edit Destinations";
            btnEditDestinations.UseVisualStyleBackColor = true;
            btnEditDestinations.Click += btnEditDestinations_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 390);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 9;
            label4.Text = "All Routes";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { routeIDDataGridViewTextBoxColumn, startDestinationIDDataGridViewTextBoxColumn, endDestinationIDDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn1, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn, schedulesDataGridViewTextBoxColumn, routeDetailsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = routeBindingSource;
            dataGridView1.Location = new Point(62, 486);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(538, 188);
            dataGridView1.TabIndex = 10;
            // 
            // routeBindingSource
            // 
            routeBindingSource.DataSource = typeof(Models.Route);
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationIDDataGridViewTextBoxColumn
            // 
            startDestinationIDDataGridViewTextBoxColumn.DataPropertyName = "StartDestinationID";
            startDestinationIDDataGridViewTextBoxColumn.HeaderText = "StartDestinationID";
            startDestinationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationIDDataGridViewTextBoxColumn.Name = "startDestinationIDDataGridViewTextBoxColumn";
            startDestinationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationIDDataGridViewTextBoxColumn
            // 
            endDestinationIDDataGridViewTextBoxColumn.DataPropertyName = "EndDestinationID";
            endDestinationIDDataGridViewTextBoxColumn.HeaderText = "EndDestinationID";
            endDestinationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationIDDataGridViewTextBoxColumn.Name = "endDestinationIDDataGridViewTextBoxColumn";
            endDestinationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startDestinationDataGridViewTextBoxColumn
            // 
            startDestinationDataGridViewTextBoxColumn.DataPropertyName = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.HeaderText = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationDataGridViewTextBoxColumn.Name = "startDestinationDataGridViewTextBoxColumn";
            startDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationDataGridViewTextBoxColumn
            // 
            endDestinationDataGridViewTextBoxColumn.DataPropertyName = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.HeaderText = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationDataGridViewTextBoxColumn.Name = "endDestinationDataGridViewTextBoxColumn";
            endDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            schedulesDataGridViewTextBoxColumn.MinimumWidth = 6;
            schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            schedulesDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeDetailsDataGridViewTextBoxColumn
            // 
            routeDetailsDataGridViewTextBoxColumn.DataPropertyName = "RouteDetails";
            routeDetailsDataGridViewTextBoxColumn.HeaderText = "RouteDetails";
            routeDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeDetailsDataGridViewTextBoxColumn.Name = "routeDetailsDataGridViewTextBoxColumn";
            routeDetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(606, 486);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 449);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 12;
            // 
            // btnSearchRoute
            // 
            btnSearchRoute.Location = new Point(262, 451);
            btnSearchRoute.Name = "btnSearchRoute";
            btnSearchRoute.Size = new Size(94, 29);
            btnSearchRoute.TabIndex = 13;
            btnSearchRoute.Text = "Search";
            btnSearchRoute.UseVisualStyleBackColor = true;
            // 
            // btnEditRoute
            // 
            btnEditRoute.Location = new Point(476, 692);
            btnEditRoute.Name = "btnEditRoute";
            btnEditRoute.Size = new Size(108, 44);
            btnEditRoute.TabIndex = 14;
            btnEditRoute.Text = "Edit Routes";
            btnEditRoute.UseVisualStyleBackColor = true;
            btnEditRoute.Click += btnEditRoute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 781);
            Controls.Add(btnEditRoute);
            Controls.Add(btnSearchRoute);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(btnEditDestinations);
            Controls.Add(label3);
            Controls.Add(dataGridViewDestinations);
            Controls.Add(btnEditDriver);
            Controls.Add(btnEditBus);
            Controls.Add(dataGridViewDrivers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewBuses);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Bus Station";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).EndInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).EndInit();
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
        private DataGridView dataGridViewDestinations;
        private DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource destinationBindingSource;
        private Label label3;
        private Button btnEditDestinations;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn startDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routeDetailsDataGridViewTextBoxColumn;
        private BindingSource routeBindingSource;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnSearchRoute;
        private Button btnEditRoute;
    }
}