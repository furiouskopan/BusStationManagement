namespace BusStationInterface.Forms
{
    partial class TicketForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewTicketSchedule = new DataGridView();
            scheduleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedArrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduleBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            cmbSeat = new ComboBox();
            seatBindingSource = new BindingSource(components);
            cmbStartDestination = new ComboBox();
            cmbEndDestination = new ComboBox();
            label3 = new Label();
            lblPrice = new Label();
            btnTicket = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTicketSchedule
            // 
            dataGridViewTicketSchedule.AllowUserToAddRows = false;
            dataGridViewTicketSchedule.AllowUserToDeleteRows = false;
            dataGridViewTicketSchedule.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTicketSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTicketSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicketSchedule.Columns.AddRange(new DataGridViewColumn[] { scheduleIDDataGridViewTextBoxColumn, busIDDataGridViewTextBoxColumn, routeIDDataGridViewTextBoxColumn, driverIDDataGridViewTextBoxColumn, departureTimeDataGridViewTextBoxColumn, estimatedArrivalTimeDataGridViewTextBoxColumn, dayDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, startDestinationIdDataGridViewTextBoxColumn, endDestinationIdDataGridViewTextBoxColumn, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn, busDataGridViewTextBoxColumn, routeDataGridViewTextBoxColumn, driverDataGridViewTextBoxColumn, ticketsDataGridViewTextBoxColumn });
            dataGridViewTicketSchedule.DataSource = scheduleBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTicketSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTicketSchedule.Location = new Point(159, 80);
            dataGridViewTicketSchedule.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTicketSchedule.Name = "dataGridViewTicketSchedule";
            dataGridViewTicketSchedule.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTicketSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTicketSchedule.RowHeadersVisible = false;
            dataGridViewTicketSchedule.RowHeadersWidth = 51;
            dataGridViewTicketSchedule.RowTemplate.Height = 29;
            dataGridViewTicketSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTicketSchedule.Size = new Size(1182, 351);
            dataGridViewTicketSchedule.TabIndex = 0;
            dataGridViewTicketSchedule.SelectionChanged += dataGridViewTicketSchedule_SelectionChanged;
            // 
            // scheduleIDDataGridViewTextBoxColumn
            // 
            scheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID";
            scheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID";
            scheduleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            scheduleIDDataGridViewTextBoxColumn.Name = "scheduleIDDataGridViewTextBoxColumn";
            scheduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            scheduleIDDataGridViewTextBoxColumn.Visible = false;
            scheduleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "BusID";
            busIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            busIDDataGridViewTextBoxColumn.ReadOnly = true;
            busIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            routeIDDataGridViewTextBoxColumn.ReadOnly = true;
            routeIDDataGridViewTextBoxColumn.Visible = false;
            routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            driverIDDataGridViewTextBoxColumn.Visible = false;
            driverIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedArrivalTimeDataGridViewTextBoxColumn
            // 
            estimatedArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedArrivalTime";
            estimatedArrivalTimeDataGridViewTextBoxColumn.HeaderText = "EstimatedArrivalTime";
            estimatedArrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimatedArrivalTimeDataGridViewTextBoxColumn.Name = "estimatedArrivalTimeDataGridViewTextBoxColumn";
            estimatedArrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            estimatedArrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "Day";
            dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.ReadOnly = true;
            dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationIdDataGridViewTextBoxColumn
            // 
            startDestinationIdDataGridViewTextBoxColumn.DataPropertyName = "StartDestinationId";
            startDestinationIdDataGridViewTextBoxColumn.HeaderText = "StartDestinationId";
            startDestinationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationIdDataGridViewTextBoxColumn.Name = "startDestinationIdDataGridViewTextBoxColumn";
            startDestinationIdDataGridViewTextBoxColumn.ReadOnly = true;
            startDestinationIdDataGridViewTextBoxColumn.Visible = false;
            startDestinationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationIdDataGridViewTextBoxColumn
            // 
            endDestinationIdDataGridViewTextBoxColumn.DataPropertyName = "EndDestinationId";
            endDestinationIdDataGridViewTextBoxColumn.HeaderText = "EndDestinationId";
            endDestinationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationIdDataGridViewTextBoxColumn.Name = "endDestinationIdDataGridViewTextBoxColumn";
            endDestinationIdDataGridViewTextBoxColumn.ReadOnly = true;
            endDestinationIdDataGridViewTextBoxColumn.Visible = false;
            endDestinationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationDataGridViewTextBoxColumn
            // 
            startDestinationDataGridViewTextBoxColumn.DataPropertyName = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.HeaderText = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationDataGridViewTextBoxColumn.Name = "startDestinationDataGridViewTextBoxColumn";
            startDestinationDataGridViewTextBoxColumn.ReadOnly = true;
            startDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationDataGridViewTextBoxColumn
            // 
            endDestinationDataGridViewTextBoxColumn.DataPropertyName = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.HeaderText = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationDataGridViewTextBoxColumn.Name = "endDestinationDataGridViewTextBoxColumn";
            endDestinationDataGridViewTextBoxColumn.ReadOnly = true;
            endDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // busDataGridViewTextBoxColumn
            // 
            busDataGridViewTextBoxColumn.DataPropertyName = "Bus";
            busDataGridViewTextBoxColumn.HeaderText = "Bus";
            busDataGridViewTextBoxColumn.MinimumWidth = 6;
            busDataGridViewTextBoxColumn.Name = "busDataGridViewTextBoxColumn";
            busDataGridViewTextBoxColumn.ReadOnly = true;
            busDataGridViewTextBoxColumn.Visible = false;
            busDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            routeDataGridViewTextBoxColumn.HeaderText = "Route";
            routeDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            routeDataGridViewTextBoxColumn.ReadOnly = true;
            routeDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            driverDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            driverDataGridViewTextBoxColumn.ReadOnly = true;
            driverDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketsDataGridViewTextBoxColumn
            // 
            ticketsDataGridViewTextBoxColumn.DataPropertyName = "Tickets";
            ticketsDataGridViewTextBoxColumn.HeaderText = "Tickets";
            ticketsDataGridViewTextBoxColumn.MinimumWidth = 6;
            ticketsDataGridViewTextBoxColumn.Name = "ticketsDataGridViewTextBoxColumn";
            ticketsDataGridViewTextBoxColumn.ReadOnly = true;
            ticketsDataGridViewTextBoxColumn.Visible = false;
            ticketsDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleBindingSource
            // 
            scheduleBindingSource.DataSource = typeof(Models.Schedule);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(656, 44);
            label1.Name = "label1";
            label1.Size = new Size(211, 34);
            label1.TabIndex = 2;
            label1.Text = "Pick a Schedule";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 445);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Seat";
            // 
            // cmbSeat
            // 
            cmbSeat.DataSource = seatBindingSource;
            cmbSeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSeat.FormattingEnabled = true;
            cmbSeat.Location = new Point(332, 467);
            cmbSeat.Margin = new Padding(3, 2, 3, 2);
            cmbSeat.Name = "cmbSeat";
            cmbSeat.Size = new Size(99, 29);
            cmbSeat.TabIndex = 1;
            // 
            // seatBindingSource
            // 
            seatBindingSource.DataSource = typeof(Models.Seat);
            // 
            // cmbStartDestination
            // 
            cmbStartDestination.DataSource = seatBindingSource;
            cmbStartDestination.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStartDestination.FormattingEnabled = true;
            cmbStartDestination.Location = new Point(536, 471);
            cmbStartDestination.Margin = new Padding(3, 2, 3, 2);
            cmbStartDestination.Name = "cmbStartDestination";
            cmbStartDestination.Size = new Size(117, 29);
            cmbStartDestination.TabIndex = 2;
            cmbStartDestination.SelectedIndexChanged += DestinationComboBox_SelectedIndexChanged;
            // 
            // cmbEndDestination
            // 
            cmbEndDestination.DataSource = seatBindingSource;
            cmbEndDestination.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEndDestination.FormattingEnabled = true;
            cmbEndDestination.Location = new Point(869, 468);
            cmbEndDestination.Margin = new Padding(3, 2, 3, 2);
            cmbEndDestination.Name = "cmbEndDestination";
            cmbEndDestination.Size = new Size(112, 29);
            cmbEndDestination.TabIndex = 3;
            cmbEndDestination.SelectedIndexChanged += DestinationComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1036, 468);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 8;
            label3.Text = "Price:";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(1088, 467);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(73, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "label4";
            // 
            // btnTicket
            // 
            btnTicket.AutoSize = false;
            btnTicket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTicket.Depth = 0;
            btnTicket.HighEmphasis = true;
            btnTicket.Icon = null;
            btnTicket.Location = new Point(682, 506);
            btnTicket.Margin = new Padding(4, 6, 4, 6);
            btnTicket.MouseState = MaterialSkin.MouseState.HOVER;
            btnTicket.Name = "btnTicket";
            btnTicket.NoAccentTextColor = Color.Empty;
            btnTicket.Size = new Size(161, 36);
            btnTicket.TabIndex = 4;
            btnTicket.Text = "Print Ticket";
            btnTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTicket.UseAccentColor = false;
            btnTicket.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 591);
            Controls.Add(btnTicket);
            Controls.Add(lblPrice);
            Controls.Add(label3);
            Controls.Add(cmbEndDestination);
            Controls.Add(cmbStartDestination);
            Controls.Add(cmbSeat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewTicketSchedule);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TicketForm";
            Text = "Ticket";
            Load += TicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTicketSchedule;
        private BindingSource scheduleBindingSource;
        private Label label1;
        private Label label2;
        private ComboBox cmbSeat;
        private BindingSource seatBindingSource;
        private DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ticketsDataGridViewTextBoxColumn;
        private ComboBox cmbStartDestination;
        private ComboBox cmbEndDestination;
        private Label label3;
        private Label lblPrice;
        private MaterialSkin.Controls.MaterialButton btnTicket;
    }
}