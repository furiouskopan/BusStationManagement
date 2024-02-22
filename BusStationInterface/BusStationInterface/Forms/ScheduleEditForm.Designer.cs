namespace BusStationInterface.Forms
{
    partial class ScheduleEditForm
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
            label3 = new Label();
            label1 = new Label();
            cmbRoute = new ComboBox();
            cmbDriver = new ComboBox();
            cmbBus = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpArrivalTime = new DateTimePicker();
            dtpDepartureTime = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dgvSchedules = new DataGridView();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedArrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduleBindingSource = new BindingSource(components);
            Day = new Label();
            cmbDay = new ComboBox();
            label6 = new Label();
            txtStatus = new TextBox();
            cmbDriverEdit = new ComboBox();
            driverBindingSource = new BindingSource(components);
            cmbBusEdit = new ComboBox();
            cmbDayEdit = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            dtpDepartureEdit = new DateTimePicker();
            dtpArrivalEdit = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtStatusEdit = new TextBox();
            label14 = new Label();
            cmbDayFilter = new ComboBox();
            txtLocationFilter = new TextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnDeleteSchedule = new MaterialSkin.Controls.MaterialButton();
            btnAddSchedule = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 51);
            label3.Name = "label3";
            label3.Size = new Size(176, 34);
            label3.TabIndex = 8;
            label3.Text = "Add Shedule";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 421);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 9;
            label1.Text = "Edit Schedules";
            // 
            // cmbRoute
            // 
            cmbRoute.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(33, 116);
            cmbRoute.Margin = new Padding(3, 2, 3, 2);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(180, 27);
            cmbRoute.TabIndex = 10;
            // 
            // cmbDriver
            // 
            cmbDriver.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(33, 164);
            cmbDriver.Margin = new Padding(3, 2, 3, 2);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(180, 27);
            cmbDriver.TabIndex = 11;
            // 
            // cmbBus
            // 
            cmbBus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBus.FormattingEnabled = true;
            cmbBus.Location = new Point(33, 219);
            cmbBus.Margin = new Padding(3, 2, 3, 2);
            cmbBus.Name = "cmbBus";
            cmbBus.Size = new Size(180, 27);
            cmbBus.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 15;
            label2.Text = "Route";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 198);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 16;
            label4.Text = "Bus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 143);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "Driver";
            // 
            // dtpArrivalTime
            // 
            dtpArrivalTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpArrivalTime.Format = DateTimePickerFormat.Custom;
            dtpArrivalTime.Location = new Point(72, 438);
            dtpArrivalTime.Margin = new Padding(3, 2, 3, 2);
            dtpArrivalTime.Name = "dtpArrivalTime";
            dtpArrivalTime.Size = new Size(87, 32);
            dtpArrivalTime.TabIndex = 19;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDepartureTime.Format = DateTimePickerFormat.Custom;
            dtpDepartureTime.ImeMode = ImeMode.NoControl;
            dtpDepartureTime.Location = new Point(72, 381);
            dtpDepartureTime.Margin = new Padding(3, 2, 3, 2);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(87, 32);
            dtpDepartureTime.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 360);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 21;
            label7.Text = "Departure time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(72, 417);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 22;
            label8.Text = "Arrival Time";
            // 
            // dgvSchedules
            // 
            dgvSchedules.AutoGenerateColumns = false;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, scheduleIDDataGridViewTextBoxColumn, routeIDDataGridViewTextBoxColumn, driverIDDataGridViewTextBoxColumn, departureTimeDataGridViewTextBoxColumn, estimatedArrivalTimeDataGridViewTextBoxColumn, dayDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, startDestinationIdDataGridViewTextBoxColumn, endDestinationIdDataGridViewTextBoxColumn, ticketsDataGridViewTextBoxColumn });
            dgvSchedules.DataSource = scheduleBindingSource;
            dgvSchedules.Location = new Point(289, 134);
            dgvSchedules.Margin = new Padding(3, 2, 3, 2);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.RowTemplate.Height = 29;
            dgvSchedules.Size = new Size(829, 265);
            dgvSchedules.TabIndex = 23;
            dgvSchedules.SelectionChanged += dataGridViewSchedules_SelectionChanged;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "BusID";
            busIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            busIDDataGridViewTextBoxColumn.Width = 125;
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
            // routeIDDataGridViewTextBoxColumn
            // 
            routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            routeIDDataGridViewTextBoxColumn.Visible = false;
            routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.Visible = false;
            driverIDDataGridViewTextBoxColumn.Width = 125;
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
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "Day";
            dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationIdDataGridViewTextBoxColumn
            // 
            startDestinationIdDataGridViewTextBoxColumn.DataPropertyName = "StartDestinationId";
            startDestinationIdDataGridViewTextBoxColumn.HeaderText = "StartDestinationId";
            startDestinationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationIdDataGridViewTextBoxColumn.Name = "startDestinationIdDataGridViewTextBoxColumn";
            startDestinationIdDataGridViewTextBoxColumn.Visible = false;
            startDestinationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationIdDataGridViewTextBoxColumn
            // 
            endDestinationIdDataGridViewTextBoxColumn.DataPropertyName = "EndDestinationId";
            endDestinationIdDataGridViewTextBoxColumn.HeaderText = "EndDestinationId";
            endDestinationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationIdDataGridViewTextBoxColumn.Name = "endDestinationIdDataGridViewTextBoxColumn";
            endDestinationIdDataGridViewTextBoxColumn.Visible = false;
            endDestinationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketsDataGridViewTextBoxColumn
            // 
            ticketsDataGridViewTextBoxColumn.DataPropertyName = "Tickets";
            ticketsDataGridViewTextBoxColumn.HeaderText = "Tickets";
            ticketsDataGridViewTextBoxColumn.MinimumWidth = 6;
            ticketsDataGridViewTextBoxColumn.Name = "ticketsDataGridViewTextBoxColumn";
            ticketsDataGridViewTextBoxColumn.Visible = false;
            ticketsDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleBindingSource
            // 
            scheduleBindingSource.DataSource = typeof(Models.Schedule);
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Day.Location = new Point(30, 251);
            Day.Name = "Day";
            Day.Size = new Size(35, 20);
            Day.TabIndex = 25;
            Day.Text = "Day";
            // 
            // cmbDay
            // 
            cmbDay.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(31, 272);
            cmbDay.Margin = new Padding(3, 2, 3, 2);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(180, 27);
            cmbDay.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 302);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 28;
            label6.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(30, 323);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(181, 23);
            txtStatus.TabIndex = 29;
            // 
            // cmbDriverEdit
            // 
            cmbDriverEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDriverEdit.FormattingEnabled = true;
            cmbDriverEdit.Location = new Point(298, 473);
            cmbDriverEdit.Margin = new Padding(3, 2, 3, 2);
            cmbDriverEdit.Name = "cmbDriverEdit";
            cmbDriverEdit.Size = new Size(180, 27);
            cmbDriverEdit.TabIndex = 30;
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // cmbBusEdit
            // 
            cmbBusEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBusEdit.FormattingEnabled = true;
            cmbBusEdit.Location = new Point(298, 526);
            cmbBusEdit.Margin = new Padding(3, 2, 3, 2);
            cmbBusEdit.Name = "cmbBusEdit";
            cmbBusEdit.Size = new Size(180, 27);
            cmbBusEdit.TabIndex = 31;
            // 
            // cmbDayEdit
            // 
            cmbDayEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDayEdit.FormattingEnabled = true;
            cmbDayEdit.Location = new Point(503, 473);
            cmbDayEdit.Margin = new Padding(3, 2, 3, 2);
            cmbDayEdit.Name = "cmbDayEdit";
            cmbDayEdit.Size = new Size(180, 27);
            cmbDayEdit.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(735, 497);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 36;
            label9.Text = "Arrival Time";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(721, 431);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 35;
            label10.Text = "Departure time";
            // 
            // dtpDepartureEdit
            // 
            dtpDepartureEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDepartureEdit.Format = DateTimePickerFormat.Custom;
            dtpDepartureEdit.ImeMode = ImeMode.NoControl;
            dtpDepartureEdit.Location = new Point(735, 452);
            dtpDepartureEdit.Margin = new Padding(3, 2, 3, 2);
            dtpDepartureEdit.Name = "dtpDepartureEdit";
            dtpDepartureEdit.Size = new Size(87, 32);
            dtpDepartureEdit.TabIndex = 34;
            // 
            // dtpArrivalEdit
            // 
            dtpArrivalEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpArrivalEdit.Format = DateTimePickerFormat.Custom;
            dtpArrivalEdit.Location = new Point(735, 518);
            dtpArrivalEdit.Margin = new Padding(3, 2, 3, 2);
            dtpArrivalEdit.Name = "dtpArrivalEdit";
            dtpArrivalEdit.Size = new Size(87, 32);
            dtpArrivalEdit.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(299, 452);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 37;
            label11.Text = "Driver";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(298, 504);
            label12.Name = "label12";
            label12.Size = new Size(32, 20);
            label12.TabIndex = 38;
            label12.Text = "Bus";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(504, 446);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 39;
            label13.Text = "Day";
            // 
            // txtStatusEdit
            // 
            txtStatusEdit.Location = new Point(502, 526);
            txtStatusEdit.Margin = new Padding(3, 2, 3, 2);
            txtStatusEdit.Name = "txtStatusEdit";
            txtStatusEdit.Size = new Size(181, 23);
            txtStatusEdit.TabIndex = 41;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(502, 504);
            label14.Name = "label14";
            label14.Size = new Size(51, 19);
            label14.TabIndex = 40;
            label14.Text = "Status";
            // 
            // cmbDayFilter
            // 
            cmbDayFilter.FormattingEnabled = true;
            cmbDayFilter.Location = new Point(301, 95);
            cmbDayFilter.Name = "cmbDayFilter";
            cmbDayFilter.Size = new Size(136, 23);
            cmbDayFilter.TabIndex = 42;
            cmbDayFilter.SelectedIndexChanged += cmbDayFilter_SelectedIndexChanged;
            // 
            // txtLocationFilter
            // 
            txtLocationFilter.Location = new Point(457, 95);
            txtLocationFilter.Name = "txtLocationFilter";
            txtLocationFilter.Size = new Size(136, 23);
            txtLocationFilter.TabIndex = 43;
            txtLocationFilter.TextChanged += txtLocationFilter_TextChanged;
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(888, 489);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(102, 36);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDeleteSchedule
            // 
            btnDeleteSchedule.AutoSize = false;
            btnDeleteSchedule.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteSchedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteSchedule.Depth = 0;
            btnDeleteSchedule.HighEmphasis = true;
            btnDeleteSchedule.Icon = null;
            btnDeleteSchedule.Location = new Point(1025, 489);
            btnDeleteSchedule.Margin = new Padding(4, 6, 4, 6);
            btnDeleteSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteSchedule.Name = "btnDeleteSchedule";
            btnDeleteSchedule.NoAccentTextColor = Color.Empty;
            btnDeleteSchedule.Size = new Size(93, 36);
            btnDeleteSchedule.TabIndex = 45;
            btnDeleteSchedule.Text = "Delete";
            btnDeleteSchedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteSchedule.UseAccentColor = false;
            btnDeleteSchedule.UseVisualStyleBackColor = true;
            btnDeleteSchedule.Click += btnDeleteSchedule_Click;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.AutoSize = false;
            btnAddSchedule.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddSchedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddSchedule.Depth = 0;
            btnAddSchedule.HighEmphasis = true;
            btnAddSchedule.Icon = null;
            btnAddSchedule.Location = new Point(34, 504);
            btnAddSchedule.Margin = new Padding(4, 6, 4, 6);
            btnAddSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.NoAccentTextColor = Color.Empty;
            btnAddSchedule.Size = new Size(172, 36);
            btnAddSchedule.TabIndex = 46;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddSchedule.UseAccentColor = false;
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // ScheduleEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 658);
            Controls.Add(btnAddSchedule);
            Controls.Add(btnDeleteSchedule);
            Controls.Add(btnSave);
            Controls.Add(txtLocationFilter);
            Controls.Add(cmbDayFilter);
            Controls.Add(txtStatusEdit);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dtpDepartureEdit);
            Controls.Add(dtpArrivalEdit);
            Controls.Add(cmbDayEdit);
            Controls.Add(cmbBusEdit);
            Controls.Add(cmbDriverEdit);
            Controls.Add(txtStatus);
            Controls.Add(label6);
            Controls.Add(Day);
            Controls.Add(cmbDay);
            Controls.Add(dgvSchedules);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpDepartureTime);
            Controls.Add(dtpArrivalTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmbBus);
            Controls.Add(cmbDriver);
            Controls.Add(cmbRoute);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScheduleEditForm";
            Text = "ScheduleEditForm";
            Load += ScheduleEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private ComboBox cmbRoute;
        private ComboBox cmbDriver;
        private ComboBox cmbBus;
        private Label label2;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpArrivalTime;
        private DateTimePicker dtpDepartureTime;
        private Label label7;
        private Label label8;
        private DataGridView dgvSchedules;
        private Label Day;
        private ComboBox cmbDay;
        private BindingSource scheduleBindingSource;
        private Label label6;
        private TextBox txtStatus;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ticketsDataGridViewTextBoxColumn;
        private ComboBox cmbDriverEdit;
        private ComboBox cmbBusEdit;
        private ComboBox cmbDayEdit;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpDepartureEdit;
        private DateTimePicker dtpArrivalEdit;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtStatusEdit;
        private Label label14;
        private BindingSource driverBindingSource;
        private ComboBox cmbDayFilter;
        private TextBox txtLocationFilter;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnDeleteSchedule;
        private MaterialSkin.Controls.MaterialButton btnAddSchedule;
    }
}