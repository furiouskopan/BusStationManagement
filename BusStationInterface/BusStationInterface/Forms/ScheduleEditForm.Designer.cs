﻿namespace BusStationInterface.Forms
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
            btnAddSchedule = new Button();
            btnSave = new Button();
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
            btnDeleteSchedule = new Button();
            label6 = new Label();
            txtStatus = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 45);
            label3.Name = "label3";
            label3.Size = new Size(176, 34);
            label3.TabIndex = 8;
            label3.Text = "Add Shedule";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 354);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 9;
            label1.Text = "Edit Schedules";
            // 
            // cmbRoute
            // 
            cmbRoute.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(27, 110);
            cmbRoute.Margin = new Padding(3, 2, 3, 2);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(180, 27);
            cmbRoute.TabIndex = 10;
            // 
            // cmbDriver
            // 
            cmbDriver.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(27, 158);
            cmbDriver.Margin = new Padding(3, 2, 3, 2);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(180, 27);
            cmbDriver.TabIndex = 11;
            // 
            // cmbBus
            // 
            cmbBus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBus.FormattingEnabled = true;
            cmbBus.Location = new Point(27, 213);
            cmbBus.Margin = new Padding(3, 2, 3, 2);
            cmbBus.Name = "cmbBus";
            cmbBus.Size = new Size(180, 27);
            cmbBus.TabIndex = 12;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(54, 488);
            btnAddSchedule.Margin = new Padding(3, 2, 3, 2);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(108, 40);
            btnAddSchedule.TabIndex = 13;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(318, 578);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 34);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 89);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 15;
            label2.Text = "Route";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 192);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 16;
            label4.Text = "Bus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "Driver";
            // 
            // dtpArrivalTime
            // 
            dtpArrivalTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpArrivalTime.Format = DateTimePickerFormat.Custom;
            dtpArrivalTime.Location = new Point(66, 432);
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
            dtpDepartureTime.Location = new Point(66, 375);
            dtpDepartureTime.Margin = new Padding(3, 2, 3, 2);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(87, 32);
            dtpDepartureTime.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 354);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 21;
            label7.Text = "Departure time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(66, 411);
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
            dgvSchedules.Location = new Point(268, 75);
            dgvSchedules.Margin = new Padding(3, 2, 3, 2);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.RowTemplate.Height = 29;
            dgvSchedules.Size = new Size(829, 265);
            dgvSchedules.TabIndex = 23;
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
            Day.Location = new Point(24, 245);
            Day.Name = "Day";
            Day.Size = new Size(35, 20);
            Day.TabIndex = 25;
            Day.Text = "Day";
            // 
            // cmbDay
            // 
            cmbDay.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(25, 266);
            cmbDay.Margin = new Padding(3, 2, 3, 2);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(180, 27);
            cmbDay.TabIndex = 24;
            // 
            // btnDeleteSchedule
            // 
            btnDeleteSchedule.Location = new Point(415, 578);
            btnDeleteSchedule.Margin = new Padding(3, 2, 3, 2);
            btnDeleteSchedule.Name = "btnDeleteSchedule";
            btnDeleteSchedule.Size = new Size(82, 34);
            btnDeleteSchedule.TabIndex = 26;
            btnDeleteSchedule.Text = "Delete";
            btnDeleteSchedule.UseVisualStyleBackColor = true;
            btnDeleteSchedule.Click += btnDeleteSchedule_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 296);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 28;
            label6.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(24, 317);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(181, 23);
            txtStatus.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(281, 406);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 27);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(281, 459);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 27);
            comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(281, 510);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 27);
            comboBox3.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(536, 466);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 36;
            label9.Text = "Arrival Time";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(522, 409);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 35;
            label10.Text = "Departure time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(536, 430);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(87, 32);
            dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(536, 487);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(87, 32);
            dateTimePicker2.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(282, 385);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 37;
            label11.Text = "Driver";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(281, 437);
            label12.Name = "label12";
            label12.Size = new Size(32, 20);
            label12.TabIndex = 38;
            label12.Text = "Bus";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(282, 488);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 39;
            label13.Text = "Day";
            // 
            // ScheduleEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 623);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtStatus);
            Controls.Add(label6);
            Controls.Add(btnDeleteSchedule);
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
            Controls.Add(btnSave);
            Controls.Add(btnAddSchedule);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private ComboBox cmbRoute;
        private ComboBox cmbDriver;
        private ComboBox cmbBus;
        private Button btnAddSchedule;
        private Button btnSave;
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
        private Button btnDeleteSchedule;
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
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}