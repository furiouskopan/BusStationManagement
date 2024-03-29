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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            dataGridViewDestinations = new DataGridView();
            destinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationBindingSource = new BindingSource(components);
            label3 = new Label();
            dataGridViewRoutes = new DataGridView();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeBindingSource1 = new BindingSource(components);
            routeBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            dataGridViewRouteDetails = new DataGridView();
            sequenceNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            routeDetailBindingSource = new BindingSource(components);
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            label8 = new Label();
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
            txtLocationFilter = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblEmployee = new Label();
            adminPanel = new Panel();
            schedulesPanel = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPageHome = new TabPage();
            btnUpdateScheduleDates = new MaterialSkin.Controls.MaterialButton();
            btnSimulation = new MaterialSkin.Controls.MaterialButton();
            btnSearchRoute = new MaterialSkin.Controls.MaterialButton();
            btnTicket = new MaterialSkin.Controls.MaterialButton();
            tabPageBuses = new TabPage();
            tabPageDrivers = new TabPage();
            tabPageLocations = new TabPage();
            tabPageRoutes = new TabPage();
            tabPageSchedules = new TabPage();
            tabPageTicket = new TabPage();
            tabPageTicketReports = new TabPage();
            tabPageLogout = new TabPage();
            imageList1 = new ImageList(components);
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
            materialTabControl1.SuspendLayout();
            tabPageHome.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewBuses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBuses.AutoGenerateColumns = false;
            dataGridViewBuses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuses.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, busTypeDataGridViewTextBoxColumn, totalSeatsDataGridViewTextBoxColumn });
            dataGridViewBuses.DataSource = busBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBuses.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBuses.EnableHeadersVisualStyles = false;
            dataGridViewBuses.Location = new Point(3, 36);
            dataGridViewBuses.Name = "dataGridViewBuses";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBuses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBuses.RowHeadersVisible = false;
            dataGridViewBuses.RowHeadersWidth = 51;
            dataGridViewBuses.RowTemplate.Height = 25;
            dataGridViewBuses.ScrollBars = ScrollBars.Vertical;
            dataGridViewBuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuses.Size = new Size(151, 150);
            dataGridViewBuses.TabIndex = 0;
            dataGridViewBuses.SelectionChanged += dataGridViewBuses_SelectionChanged;
            dataGridViewBuses.MouseClick += dataGridViewBuses_MouseClick;
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "All Buses\r\n";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(193, 8);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
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
            dataGridViewDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDrivers.AutoGenerateColumns = false;
            dataGridViewDrivers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn });
            dataGridViewDrivers.DataSource = driverBindingSource;
            dataGridViewDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDrivers.EnableHeadersVisualStyles = false;
            dataGridViewDrivers.Location = new Point(178, 36);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.RowHeadersVisible = false;
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.RowTemplate.Height = 25;
            dataGridViewDrivers.ScrollBars = ScrollBars.Vertical;
            dataGridViewDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDrivers.Size = new Size(273, 149);
            dataGridViewDrivers.TabIndex = 3;
            dataGridViewDrivers.SelectionChanged += dataGridViewDrivers_SelectionChanged;
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
            // dataGridViewDestinations
            // 
            dataGridViewDestinations.AllowUserToAddRows = false;
            dataGridViewDestinations.AllowUserToDeleteRows = false;
            dataGridViewDestinations.AllowUserToResizeColumns = false;
            dataGridViewDestinations.AllowUserToResizeRows = false;
            dataGridViewDestinations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDestinations.AutoGenerateColumns = false;
            dataGridViewDestinations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewDestinations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewDestinations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDestinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinations.Columns.AddRange(new DataGridViewColumn[] { destinationIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn });
            dataGridViewDestinations.DataSource = destinationBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewDestinations.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewDestinations.EnableHeadersVisualStyles = false;
            dataGridViewDestinations.Location = new Point(471, 36);
            dataGridViewDestinations.Name = "dataGridViewDestinations";
            dataGridViewDestinations.ReadOnly = true;
            dataGridViewDestinations.RightToLeft = RightToLeft.No;
            dataGridViewDestinations.RowHeadersVisible = false;
            dataGridViewDestinations.RowHeadersWidth = 51;
            dataGridViewDestinations.RowTemplate.Height = 25;
            dataGridViewDestinations.ScrollBars = ScrollBars.Vertical;
            dataGridViewDestinations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDestinations.Size = new Size(373, 150);
            dataGridViewDestinations.TabIndex = 6;
            dataGridViewDestinations.SelectionChanged += dataGridViewDestinations_SelectionChanged;
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
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(471, 6);
            label3.Name = "label3";
            label3.Size = new Size(167, 27);
            label3.TabIndex = 7;
            label3.Text = "All Destinations";
            // 
            // dataGridViewRoutes
            // 
            dataGridViewRoutes.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewRoutes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewRoutes.AutoGenerateColumns = false;
            dataGridViewRoutes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewRoutes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { descriptionDataGridViewTextBoxColumn1, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn });
            dataGridViewRoutes.DataSource = routeBindingSource1;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewRoutes.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewRoutes.EnableHeadersVisualStyles = false;
            dataGridViewRoutes.Location = new Point(15, 332);
            dataGridViewRoutes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRoutes.Name = "dataGridViewRoutes";
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.RowHeadersWidth = 51;
            dataGridViewRoutes.RowTemplate.Height = 29;
            dataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes.Size = new Size(377, 189);
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
            textBox1.Location = new Point(15, 307);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 12;
            // 
            // dataGridViewRouteDetails
            // 
            dataGridViewRouteDetails.AllowUserToResizeRows = false;
            dataGridViewRouteDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewRouteDetails.AutoGenerateColumns = false;
            dataGridViewRouteDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewRouteDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewRouteDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRouteDetails.Columns.AddRange(new DataGridViewColumn[] { sequenceNumberDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn2, LocationName });
            dataGridViewRouteDetails.DataSource = routeDetailBindingSource;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewRouteDetails.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewRouteDetails.EnableHeadersVisualStyles = false;
            dataGridViewRouteDetails.Location = new Point(441, 331);
            dataGridViewRouteDetails.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRouteDetails.Name = "dataGridViewRouteDetails";
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.RowHeadersWidth = 51;
            dataGridViewRouteDetails.RowTemplate.Height = 29;
            dataGridViewRouteDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRouteDetails.Size = new Size(428, 189);
            dataGridViewRouteDetails.TabIndex = 15;
            dataGridViewRouteDetails.CellFormatting += dataGridViewRouteDetails_CellFormatting;
            dataGridViewRouteDetails.SelectionChanged += dataGridViewRouteDetails_SelectionChanged;
            // 
            // sequenceNumberDataGridViewTextBoxColumn
            // 
            sequenceNumberDataGridViewTextBoxColumn.DataPropertyName = "SequenceNumber";
            sequenceNumberDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            sequenceNumberDataGridViewTextBoxColumn.Name = "sequenceNumberDataGridViewTextBoxColumn";
            sequenceNumberDataGridViewTextBoxColumn.Width = 80;
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
            // LocationName
            // 
            LocationName.DataPropertyName = "LocationName";
            LocationName.HeaderText = "Location";
            LocationName.MinimumWidth = 6;
            LocationName.Name = "LocationName";
            LocationName.Width = 125;
            // 
            // routeDetailBindingSource
            // 
            routeDetailBindingSource.DataSource = typeof(Models.RouteDetail);
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(446, 297);
            label5.Name = "label5";
            label5.Size = new Size(220, 25);
            label5.TabIndex = 17;
            label5.Text = "Selected Route Details";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Verdana", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.Brown;
            lblTimer.Location = new Point(1277, 0);
            lblTimer.Margin = new Padding(0, 38, 0, 38);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(296, 28);
            lblTimer.TabIndex = 21;
            lblTimer.Text = "label8";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(14, 9);
            label8.Name = "label8";
            label8.Size = new Size(193, 27);
            label8.TabIndex = 22;
            label8.Text = "Today's Schedules";
            // 
            // dataGridViewSchedules
            // 
            dataGridViewSchedules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSchedules.AutoGenerateColumns = false;
            dataGridViewSchedules.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedules.Columns.AddRange(new DataGridViewColumn[] { Status, DriverID, Driver, scheduleIDDataGridViewTextBoxColumn, busIDDataGridViewTextBoxColumn1, departureTimeDataGridViewTextBoxColumn, estimatedArrivalTimeDataGridViewTextBoxColumn, Route, RouteID, dayDataGridViewTextBoxColumn });
            dataGridViewSchedules.DataSource = scheduleBindingSource;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridViewSchedules.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewSchedules.EnableHeadersVisualStyles = false;
            dataGridViewSchedules.Location = new Point(3, 38);
            dataGridViewSchedules.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSchedules.Name = "dataGridViewSchedules";
            dataGridViewSchedules.RowHeadersVisible = false;
            dataGridViewSchedules.RowHeadersWidth = 51;
            dataGridViewSchedules.RowTemplate.Height = 29;
            dataGridViewSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSchedules.Size = new Size(602, 161);
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
            // txtLocationFilter
            // 
            txtLocationFilter.Location = new Point(462, 11);
            txtLocationFilter.Margin = new Padding(3, 2, 3, 2);
            txtLocationFilter.Name = "txtLocationFilter";
            txtLocationFilter.Size = new Size(143, 23);
            txtLocationFilter.TabIndex = 25;
            txtLocationFilter.TextChanged += txtLocationFilter_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblEmployee
            // 
            lblEmployee.BackColor = Color.Transparent;
            lblEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployee.ForeColor = Color.Black;
            lblEmployee.Location = new Point(50, 15);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(182, 25);
            lblEmployee.TabIndex = 28;
            lblEmployee.Text = "label9";
            // 
            // adminPanel
            // 
            adminPanel.BackColor = Color.Transparent;
            adminPanel.Controls.Add(dataGridViewDestinations);
            adminPanel.Controls.Add(dataGridViewBuses);
            adminPanel.Controls.Add(label1);
            adminPanel.Controls.Add(label2);
            adminPanel.Controls.Add(dataGridViewDrivers);
            adminPanel.Controls.Add(label3);
            adminPanel.Location = new Point(16, 52);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(876, 224);
            adminPanel.TabIndex = 29;
            // 
            // schedulesPanel
            // 
            schedulesPanel.BackColor = Color.Transparent;
            schedulesPanel.Controls.Add(dataGridViewSchedules);
            schedulesPanel.Controls.Add(label8);
            schedulesPanel.Controls.Add(txtLocationFilter);
            schedulesPanel.Location = new Point(898, 50);
            schedulesPanel.Name = "schedulesPanel";
            schedulesPanel.Size = new Size(608, 226);
            schedulesPanel.TabIndex = 30;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(123, -21);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(31, 19);
            materialLabel1.TabIndex = 31;
            materialLabel1.Text = "BUS";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = SystemColors.HotTrack;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ForeColor = Color.Brown;
            materialLabel2.Location = new Point(160, -21);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(69, 19);
            materialLabel2.TabIndex = 32;
            materialLabel2.Text = "EXPRESS";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageHome);
            materialTabControl1.Controls.Add(tabPageBuses);
            materialTabControl1.Controls.Add(tabPageDrivers);
            materialTabControl1.Controls.Add(tabPageLocations);
            materialTabControl1.Controls.Add(tabPageRoutes);
            materialTabControl1.Controls.Add(tabPageSchedules);
            materialTabControl1.Controls.Add(tabPageTicket);
            materialTabControl1.Controls.Add(tabPageTicketReports);
            materialTabControl1.Controls.Add(tabPageLogout);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1594, 633);
            materialTabControl1.TabIndex = 33;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(btnUpdateScheduleDates);
            tabPageHome.Controls.Add(btnSimulation);
            tabPageHome.Controls.Add(lblEmployee);
            tabPageHome.Controls.Add(btnSearchRoute);
            tabPageHome.Controls.Add(btnTicket);
            tabPageHome.Controls.Add(adminPanel);
            tabPageHome.Controls.Add(dataGridViewRoutes);
            tabPageHome.Controls.Add(materialLabel2);
            tabPageHome.Controls.Add(textBox1);
            tabPageHome.Controls.Add(materialLabel1);
            tabPageHome.Controls.Add(schedulesPanel);
            tabPageHome.Controls.Add(dataGridViewRouteDetails);
            tabPageHome.Controls.Add(label5);
            tabPageHome.Controls.Add(lblTimer);
            tabPageHome.ImageKey = "icons8-home-52.png";
            tabPageHome.Location = new Point(4, 39);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1586, 590);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // btnUpdateScheduleDates
            // 
            btnUpdateScheduleDates.AutoSize = false;
            btnUpdateScheduleDates.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateScheduleDates.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateScheduleDates.Depth = 0;
            btnUpdateScheduleDates.HighEmphasis = true;
            btnUpdateScheduleDates.Icon = null;
            btnUpdateScheduleDates.Location = new Point(441, 528);
            btnUpdateScheduleDates.Margin = new Padding(4, 6, 4, 6);
            btnUpdateScheduleDates.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateScheduleDates.Name = "btnUpdateScheduleDates";
            btnUpdateScheduleDates.NoAccentTextColor = Color.Empty;
            btnUpdateScheduleDates.Size = new Size(177, 36);
            btnUpdateScheduleDates.TabIndex = 37;
            btnUpdateScheduleDates.Text = "Update Schedules";
            btnUpdateScheduleDates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateScheduleDates.UseAccentColor = false;
            btnUpdateScheduleDates.UseVisualStyleBackColor = true;
            btnUpdateScheduleDates.Click += btnUpdateScheduleDates_Click;
            // 
            // btnSimulation
            // 
            btnSimulation.AutoSize = false;
            btnSimulation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSimulation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSimulation.Depth = 0;
            btnSimulation.HighEmphasis = true;
            btnSimulation.Icon = null;
            btnSimulation.Location = new Point(752, 527);
            btnSimulation.Margin = new Padding(4, 6, 4, 6);
            btnSimulation.MouseState = MaterialSkin.MouseState.HOVER;
            btnSimulation.Name = "btnSimulation";
            btnSimulation.NoAccentTextColor = Color.Empty;
            btnSimulation.Size = new Size(117, 36);
            btnSimulation.TabIndex = 36;
            btnSimulation.Text = "Simulation";
            btnSimulation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSimulation.UseAccentColor = false;
            btnSimulation.UseVisualStyleBackColor = true;
            btnSimulation.Click += btnSimulation_Click;
            // 
            // btnSearchRoute
            // 
            btnSearchRoute.AutoSize = false;
            btnSearchRoute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchRoute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearchRoute.Depth = 0;
            btnSearchRoute.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchRoute.HighEmphasis = true;
            btnSearchRoute.Icon = null;
            btnSearchRoute.Location = new Point(264, 299);
            btnSearchRoute.Margin = new Padding(4, 6, 4, 6);
            btnSearchRoute.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearchRoute.Name = "btnSearchRoute";
            btnSearchRoute.NoAccentTextColor = Color.Empty;
            btnSearchRoute.Size = new Size(128, 32);
            btnSearchRoute.TabIndex = 34;
            btnSearchRoute.Text = "Search route";
            btnSearchRoute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearchRoute.UseAccentColor = false;
            btnSearchRoute.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            btnTicket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTicket.Depth = 0;
            btnTicket.HighEmphasis = true;
            btnTicket.Icon = null;
            btnTicket.Location = new Point(798, 287);
            btnTicket.Margin = new Padding(4, 6, 4, 6);
            btnTicket.MouseState = MaterialSkin.MouseState.HOVER;
            btnTicket.Name = "btnTicket";
            btnTicket.NoAccentTextColor = Color.Empty;
            btnTicket.Size = new Size(71, 36);
            btnTicket.TabIndex = 33;
            btnTicket.Text = "Ticket";
            btnTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTicket.UseAccentColor = false;
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // tabPageBuses
            // 
            tabPageBuses.ImageKey = "icons8-bus-52.png";
            tabPageBuses.Location = new Point(4, 39);
            tabPageBuses.Name = "tabPageBuses";
            tabPageBuses.Padding = new Padding(3);
            tabPageBuses.Size = new Size(1586, 590);
            tabPageBuses.TabIndex = 1;
            tabPageBuses.Text = "Buses";
            tabPageBuses.UseVisualStyleBackColor = true;
            // 
            // tabPageDrivers
            // 
            tabPageDrivers.ImageKey = "icons8-driver-52.png";
            tabPageDrivers.Location = new Point(4, 39);
            tabPageDrivers.Name = "tabPageDrivers";
            tabPageDrivers.Size = new Size(1586, 590);
            tabPageDrivers.TabIndex = 2;
            tabPageDrivers.Text = "Drivers";
            tabPageDrivers.UseVisualStyleBackColor = true;
            // 
            // tabPageLocations
            // 
            tabPageLocations.ImageKey = "icons8-location-52.png";
            tabPageLocations.Location = new Point(4, 39);
            tabPageLocations.Name = "tabPageLocations";
            tabPageLocations.Size = new Size(1586, 590);
            tabPageLocations.TabIndex = 3;
            tabPageLocations.Text = "Locations";
            tabPageLocations.UseVisualStyleBackColor = true;
            // 
            // tabPageRoutes
            // 
            tabPageRoutes.ImageKey = "icons8-route-52.png";
            tabPageRoutes.Location = new Point(4, 39);
            tabPageRoutes.Name = "tabPageRoutes";
            tabPageRoutes.Size = new Size(1586, 590);
            tabPageRoutes.TabIndex = 4;
            tabPageRoutes.Text = "Routes";
            tabPageRoutes.UseVisualStyleBackColor = true;
            // 
            // tabPageSchedules
            // 
            tabPageSchedules.ImageKey = "icons8-schedule-52.png";
            tabPageSchedules.Location = new Point(4, 39);
            tabPageSchedules.Name = "tabPageSchedules";
            tabPageSchedules.Size = new Size(1586, 590);
            tabPageSchedules.TabIndex = 5;
            tabPageSchedules.Text = "Schedules";
            tabPageSchedules.UseVisualStyleBackColor = true;
            // 
            // tabPageTicket
            // 
            tabPageTicket.ImageKey = "tickets.png";
            tabPageTicket.Location = new Point(4, 39);
            tabPageTicket.Name = "tabPageTicket";
            tabPageTicket.Size = new Size(1586, 590);
            tabPageTicket.TabIndex = 8;
            tabPageTicket.Text = "Ticket";
            tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // tabPageTicketReports
            // 
            tabPageTicketReports.ImageKey = "icons8-document-52.png";
            tabPageTicketReports.Location = new Point(4, 39);
            tabPageTicketReports.Name = "tabPageTicketReports";
            tabPageTicketReports.Size = new Size(1586, 590);
            tabPageTicketReports.TabIndex = 7;
            tabPageTicketReports.Text = "Ticket Reports";
            tabPageTicketReports.UseVisualStyleBackColor = true;
            // 
            // tabPageLogout
            // 
            tabPageLogout.ImageKey = "icons8-logout-48.png";
            tabPageLogout.Location = new Point(4, 39);
            tabPageLogout.Name = "tabPageLogout";
            tabPageLogout.Padding = new Padding(3);
            tabPageLogout.Size = new Size(1586, 590);
            tabPageLogout.TabIndex = 6;
            tabPageLogout.Text = "Logout";
            tabPageLogout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-home-52.png");
            imageList1.Images.SetKeyName(1, "icons8-bus-52.png");
            imageList1.Images.SetKeyName(2, "icons8-driver-52.png");
            imageList1.Images.SetKeyName(3, "icons8-location-52.png");
            imageList1.Images.SetKeyName(4, "icons8-route-52.png");
            imageList1.Images.SetKeyName(5, "icons8-schedule-52.png");
            imageList1.Images.SetKeyName(6, "icons8-document-52.png");
            imageList1.Images.SetKeyName(7, "icons8-logout-48.png");
            imageList1.Images.SetKeyName(8, "tickets.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1600, 700);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1600, 700);
            MinimumSize = new Size(1600, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Strumica Bus Station";
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
            schedulesPanel.ResumeLayout(false);
            schedulesPanel.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            ResumeLayout(false);
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
        private DataGridView dataGridViewDestinations;
        private DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource destinationBindingSource;
        private Label label3;
        private DataGridView dataGridViewRoutes;
        private TextBox textBox1;
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
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Label label8;
        private DataGridView dataGridViewSchedules;
        private BindingSource scheduleBindingSource;
        private TextBox txtLocationFilter;
        private DataGridViewTextBoxColumn DriverColumn;
        private ContextMenuStrip contextMenuStrip1;
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
        private Label lblEmployee;
        private Panel adminPanel;
        private Panel schedulesPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageHome;
        private TabPage tabPageBuses;
        private ImageList imageList1;
        private TabPage tabPageDrivers;
        private TabPage tabPageLocations;
        private TabPage tabPageRoutes;
        private TabPage tabPageSchedules;
        private TabPage tabPageLogout;
        private MaterialSkin.Controls.MaterialButton btnSearchRoute;
        private MaterialSkin.Controls.MaterialButton btnTicket;
        private TabPage tabPageTicketReports;
        private TabPage tabPageTicket;
        private MaterialSkin.Controls.MaterialButton btnSimulation;
        private MaterialSkin.Controls.MaterialButton btnUpdateScheduleDates;
    }
}