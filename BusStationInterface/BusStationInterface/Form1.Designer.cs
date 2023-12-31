﻿namespace BusStationInterface
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
            dataGridViewRoutes = new DataGridView();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeBindingSource1 = new BindingSource(components);
            routeBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            btnSearchRoute = new Button();
            dataGridViewRouteDetails = new DataGridView();
            sequenceNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            routeDetailBindingSource = new BindingSource(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnEditRD = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            label8 = new Label();
            btnEditSchedules = new Button();
            dataGridViewSchedules = new DataGridView();
            Status = new DataGridViewTextBoxColumn();
            DriverID = new DataGridViewTextBoxColumn();
            Driver = new DataGridViewTextBoxColumn();
            scheduleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedArrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Route = new DataGridViewTextBoxColumn();
            RouteID = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduleBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnTicket = new Button();
            label9 = new Label();
            adminPanel = new Panel();
            schedulesPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRouteDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).BeginInit();
            adminPanel.SuspendLayout();
            schedulesPanel.SuspendLayout();
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
            dataGridViewBuses.Location = new Point(17, 36);
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
            dataGridViewBuses.ScrollBars = ScrollBars.Vertical;
            dataGridViewBuses.Size = new Size(151, 150);
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
            busTypeDataGridViewTextBoxColumn.Width = 70;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            totalSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            totalSeatsDataGridViewTextBoxColumn.Width = 50;
            // 
            // busBindingSource
            // 
            busBindingSource.DataSource = typeof(Models.Bus);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "All Buses\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(221, 9);
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
            dataGridViewDrivers.AllowUserToResizeColumns = false;
            dataGridViewDrivers.AllowUserToResizeRows = false;
            dataGridViewDrivers.AutoGenerateColumns = false;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn });
            dataGridViewDrivers.DataSource = driverBindingSource;
            dataGridViewDrivers.Location = new Point(221, 37);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.RowTemplate.Height = 25;
            dataGridViewDrivers.ScrollBars = ScrollBars.Vertical;
            dataGridViewDrivers.Size = new Size(273, 149);
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
            btnEditBus.Location = new Point(17, 192);
            btnEditBus.Name = "btnEditBus";
            btnEditBus.Size = new Size(90, 40);
            btnEditBus.TabIndex = 4;
            btnEditBus.Text = "Edit Buses";
            btnEditBus.UseVisualStyleBackColor = true;
            btnEditBus.Click += btnEditBus_Click;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(221, 192);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(90, 40);
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
            dataGridViewDestinations.GridColor = SystemColors.ButtonHighlight;
            dataGridViewDestinations.Location = new Point(544, 40);
            dataGridViewDestinations.Name = "dataGridViewDestinations";
            dataGridViewDestinations.ReadOnly = true;
            dataGridViewDestinations.RightToLeft = RightToLeft.No;
            dataGridViewDestinations.RowHeadersWidth = 51;
            dataGridViewDestinations.RowTemplate.Height = 25;
            dataGridViewDestinations.ScrollBars = ScrollBars.Vertical;
            dataGridViewDestinations.Size = new Size(373, 150);
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
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(544, 10);
            label3.Name = "label3";
            label3.Size = new Size(167, 27);
            label3.TabIndex = 7;
            label3.Text = "All Destinations";
            // 
            // btnEditDestinations
            // 
            btnEditDestinations.Location = new Point(783, 196);
            btnEditDestinations.Name = "btnEditDestinations";
            btnEditDestinations.Size = new Size(134, 40);
            btnEditDestinations.TabIndex = 8;
            btnEditDestinations.Text = "Edit Destinations";
            btnEditDestinations.UseVisualStyleBackColor = true;
            btnEditDestinations.Click += btnEditDestinations_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 318);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 9;
            label4.Text = "All Routes";
            // 
            // dataGridViewRoutes
            // 
            dataGridViewRoutes.AllowUserToResizeRows = false;
            dataGridViewRoutes.AutoGenerateColumns = false;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { descriptionDataGridViewTextBoxColumn1, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn });
            dataGridViewRoutes.DataSource = routeBindingSource1;
            dataGridViewRoutes.Location = new Point(17, 370);
            dataGridViewRoutes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRoutes.Name = "dataGridViewRoutes";
            dataGridViewRoutes.RowHeadersWidth = 51;
            dataGridViewRoutes.RowTemplate.Height = 29;
            dataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes.Size = new Size(430, 189);
            dataGridViewRoutes.TabIndex = 10;
            dataGridViewRoutes.SelectionChanged += dataGridViewRoutes_SelectionChanged;
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
            // routeBindingSource1
            // 
            routeBindingSource1.DataSource = typeof(Models.Route);
            // 
            // routeBindingSource
            // 
            routeBindingSource.DataSource = typeof(Models.Route);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 345);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 12;
            // 
            // btnSearchRoute
            // 
            btnSearchRoute.Location = new Point(166, 343);
            btnSearchRoute.Margin = new Padding(3, 2, 3, 2);
            btnSearchRoute.Name = "btnSearchRoute";
            btnSearchRoute.Size = new Size(82, 25);
            btnSearchRoute.TabIndex = 13;
            btnSearchRoute.Text = "Search";
            btnSearchRoute.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRouteDetails
            // 
            dataGridViewRouteDetails.AllowUserToResizeRows = false;
            dataGridViewRouteDetails.AutoGenerateColumns = false;
            dataGridViewRouteDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRouteDetails.Columns.AddRange(new DataGridViewColumn[] { sequenceNumberDataGridViewTextBoxColumn, LocationName, timeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn2 });
            dataGridViewRouteDetails.DataSource = routeDetailBindingSource;
            dataGridViewRouteDetails.Location = new Point(493, 370);
            dataGridViewRouteDetails.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRouteDetails.Name = "dataGridViewRouteDetails";
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.RowHeadersWidth = 51;
            dataGridViewRouteDetails.RowTemplate.Height = 29;
            dataGridViewRouteDetails.Size = new Size(428, 189);
            dataGridViewRouteDetails.TabIndex = 15;
            // 
            // sequenceNumberDataGridViewTextBoxColumn
            // 
            sequenceNumberDataGridViewTextBoxColumn.DataPropertyName = "SequenceNumber";
            sequenceNumberDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            sequenceNumberDataGridViewTextBoxColumn.Name = "sequenceNumberDataGridViewTextBoxColumn";
            sequenceNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // LocationName
            // 
            LocationName.DataPropertyName = "LocationName";
            LocationName.HeaderText = "Location";
            LocationName.MinimumWidth = 6;
            LocationName.Name = "LocationName";
            LocationName.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 70;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            descriptionDataGridViewTextBoxColumn2.Width = 150;
            // 
            // routeDetailBindingSource
            // 
            routeDetailBindingSource.DataSource = typeof(Models.RouteDetail);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(498, 336);
            label5.Name = "label5";
            label5.Size = new Size(220, 25);
            label5.TabIndex = 17;
            label5.Text = "Selected Route Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 31);
            label6.Name = "label6";
            label6.Size = new Size(83, 33);
            label6.TabIndex = 18;
            label6.Text = "BUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(116, 31);
            label7.Name = "label7";
            label7.Size = new Size(168, 33);
            label7.TabIndex = 19;
            label7.Text = "EXPRESS";
            // 
            // btnEditRD
            // 
            btnEditRD.Location = new Point(422, 563);
            btnEditRD.Margin = new Padding(3, 2, 3, 2);
            btnEditRD.Name = "btnEditRD";
            btnEditRD.Size = new Size(94, 42);
            btnEditRD.TabIndex = 20;
            btnEditRD.Text = "Edit RD";
            btnEditRD.UseVisualStyleBackColor = true;
            btnEditRD.Click += btnEditRD_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Dock = DockStyle.Right;
            lblTimer.Font = new Font("Verdana", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.Red;
            lblTimer.Location = new Point(1424, 0);
            lblTimer.Margin = new Padding(0, 38, 0, 38);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(81, 28);
            lblTimer.TabIndex = 21;
            lblTimer.Text = "label8";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 20);
            label8.Name = "label8";
            label8.Size = new Size(193, 27);
            label8.TabIndex = 22;
            label8.Text = "Today's Schedules";
            // 
            // btnEditSchedules
            // 
            btnEditSchedules.Location = new Point(401, 206);
            btnEditSchedules.Margin = new Padding(3, 2, 3, 2);
            btnEditSchedules.Name = "btnEditSchedules";
            btnEditSchedules.Size = new Size(123, 40);
            btnEditSchedules.TabIndex = 23;
            btnEditSchedules.Text = "Edit Schedules";
            btnEditSchedules.UseVisualStyleBackColor = true;
            btnEditSchedules.Click += btnEditSchedules_Click;
            // 
            // dataGridViewSchedules
            // 
            dataGridViewSchedules.AutoGenerateColumns = false;
            dataGridViewSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedules.Columns.AddRange(new DataGridViewColumn[] { Status, DriverID, Driver, scheduleIDDataGridViewTextBoxColumn, busIDDataGridViewTextBoxColumn1, departureTimeDataGridViewTextBoxColumn, estimatedArrivalTimeDataGridViewTextBoxColumn, Route, RouteID, dayDataGridViewTextBoxColumn });
            dataGridViewSchedules.DataSource = scheduleBindingSource;
            dataGridViewSchedules.Location = new Point(14, 52);
            dataGridViewSchedules.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSchedules.Name = "dataGridViewSchedules";
            dataGridViewSchedules.RowHeadersWidth = 51;
            dataGridViewSchedules.RowTemplate.Height = 29;
            dataGridViewSchedules.Size = new Size(510, 150);
            dataGridViewSchedules.TabIndex = 24;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // DriverID
            // 
            DriverID.DataPropertyName = "DriverID";
            DriverID.HeaderText = "DriverID";
            DriverID.MinimumWidth = 6;
            DriverID.Name = "DriverID";
            DriverID.Visible = false;
            DriverID.Width = 125;
            // 
            // Driver
            // 
            Driver.DataPropertyName = "Driver";
            Driver.HeaderText = "Driver";
            Driver.MinimumWidth = 6;
            Driver.Name = "Driver";
            Driver.Visible = false;
            Driver.Width = 125;
            // 
            // scheduleIDDataGridViewTextBoxColumn
            // 
            scheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID";
            scheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID";
            scheduleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            scheduleIDDataGridViewTextBoxColumn.Name = "scheduleIDDataGridViewTextBoxColumn";
            scheduleIDDataGridViewTextBoxColumn.Visible = false;
            scheduleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // busIDDataGridViewTextBoxColumn1
            // 
            busIDDataGridViewTextBoxColumn1.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn1.HeaderText = "BusID";
            busIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            busIDDataGridViewTextBoxColumn1.Name = "busIDDataGridViewTextBoxColumn1";
            busIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedArrivalTimeDataGridViewTextBoxColumn
            // 
            estimatedArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedArrivalTime";
            estimatedArrivalTimeDataGridViewTextBoxColumn.HeaderText = "EstimatedArrivalTime";
            estimatedArrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimatedArrivalTimeDataGridViewTextBoxColumn.Name = "estimatedArrivalTimeDataGridViewTextBoxColumn";
            estimatedArrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Route
            // 
            Route.DataPropertyName = "Route";
            Route.HeaderText = "Route";
            Route.MinimumWidth = 6;
            Route.Name = "Route";
            Route.Width = 125;
            // 
            // RouteID
            // 
            RouteID.DataPropertyName = "RouteID";
            RouteID.HeaderText = "RouteID";
            RouteID.MinimumWidth = 6;
            RouteID.Name = "RouteID";
            RouteID.Visible = false;
            RouteID.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "Day";
            dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleBindingSource
            // 
            scheduleBindingSource.DataSource = typeof(Models.Schedule);
            // 
            // button1
            // 
            button1.Location = new Point(442, 23);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 26;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 25);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(827, 326);
            btnTicket.Margin = new Padding(3, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(94, 35);
            btnTicket.TabIndex = 27;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(8, 6);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 28;
            label9.Text = "label9";
            // 
            // adminPanel
            // 
            adminPanel.BackColor = Color.Transparent;
            adminPanel.Controls.Add(dataGridViewDestinations);
            adminPanel.Controls.Add(dataGridViewBuses);
            adminPanel.Controls.Add(label1);
            adminPanel.Controls.Add(label2);
            adminPanel.Controls.Add(dataGridViewDrivers);
            adminPanel.Controls.Add(btnEditBus);
            adminPanel.Controls.Add(btnEditDriver);
            adminPanel.Controls.Add(label3);
            adminPanel.Controls.Add(btnEditDestinations);
            adminPanel.Location = new Point(17, 67);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(934, 248);
            adminPanel.TabIndex = 29;
            // 
            // schedulesPanel
            // 
            schedulesPanel.BackColor = Color.Transparent;
            schedulesPanel.Controls.Add(dataGridViewSchedules);
            schedulesPanel.Controls.Add(label8);
            schedulesPanel.Controls.Add(btnEditSchedules);
            schedulesPanel.Controls.Add(textBox2);
            schedulesPanel.Controls.Add(button1);
            schedulesPanel.Location = new Point(957, 65);
            schedulesPanel.Name = "schedulesPanel";
            schedulesPanel.Size = new Size(536, 254);
            schedulesPanel.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources.bgbgbg;
            ClientSize = new Size(1505, 613);
            Controls.Add(schedulesPanel);
            Controls.Add(adminPanel);
            Controls.Add(label9);
            Controls.Add(btnTicket);
            Controls.Add(lblTimer);
            Controls.Add(btnEditRD);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridViewRouteDetails);
            Controls.Add(btnSearchRoute);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewRoutes);
            Controls.Add(label4);
            MaximumSize = new Size(1521, 652);
            MinimumSize = new Size(960, 652);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bus Station";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).EndInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRouteDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).EndInit();
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            schedulesPanel.ResumeLayout(false);
            schedulesPanel.PerformLayout();
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
        private DataGridView dataGridViewRoutes;
        private TextBox textBox1;
        private Button btnSearchRoute;
        private BindingSource routeBindingSource;
        private BindingSource routeBindingSource1;
        private DataGridView dataGridViewRouteDetails;
        private BindingSource routeDetailBindingSource;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private Label label5;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn startDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationDataGridViewTextBoxColumn;
        private Label label6;
        private Label label7;
        private Button btnEditRD;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Label label8;
        private Button btnEditSchedules;
        private DataGridView dataGridViewSchedules;
        private BindingSource scheduleBindingSource;
        private Button button1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn DriverColumn;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnTicket;
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LocationName;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn RouteID;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private Label label9;
        private Panel adminPanel;
        private Panel schedulesPanel;
    }
}