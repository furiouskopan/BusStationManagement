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
            dataGridViewTicketSchedule = new DataGridView();
            scheduleBindingSource = new BindingSource(components);
            btnTicket = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbSeat = new ComboBox();
            seatBindingSource = new BindingSource(components);
            scheduleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedArrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            dataGridViewTicketSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicketSchedule.Columns.AddRange(new DataGridViewColumn[] { scheduleIDDataGridViewTextBoxColumn, busIDDataGridViewTextBoxColumn, routeIDDataGridViewTextBoxColumn, driverIDDataGridViewTextBoxColumn, departureTimeDataGridViewTextBoxColumn, estimatedArrivalTimeDataGridViewTextBoxColumn, dayDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, startDestinationIdDataGridViewTextBoxColumn, endDestinationIdDataGridViewTextBoxColumn, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn, busDataGridViewTextBoxColumn, routeDataGridViewTextBoxColumn, driverDataGridViewTextBoxColumn, ticketsDataGridViewTextBoxColumn });
            dataGridViewTicketSchedule.DataSource = scheduleBindingSource;
            dataGridViewTicketSchedule.Location = new Point(12, 49);
            dataGridViewTicketSchedule.Name = "dataGridViewTicketSchedule";
            dataGridViewTicketSchedule.ReadOnly = true;
            dataGridViewTicketSchedule.RowHeadersWidth = 51;
            dataGridViewTicketSchedule.RowTemplate.Height = 29;
            dataGridViewTicketSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTicketSchedule.Size = new Size(1071, 358);
            dataGridViewTicketSchedule.TabIndex = 0;
            dataGridViewTicketSchedule.SelectionChanged += dataGridViewTicketSchedule_SelectionChanged;
            // 
            // scheduleBindingSource
            // 
            scheduleBindingSource.DataSource = typeof(Models.Schedule);
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(480, 536);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(130, 48);
            btnTicket.TabIndex = 1;
            btnTicket.Text = "Print Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 18);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 2;
            label1.Text = "Pick a Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 414);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Seat";
            // 
            // cmbSeat
            // 
            cmbSeat.DataSource = seatBindingSource;
            cmbSeat.FormattingEnabled = true;
            cmbSeat.Location = new Point(12, 437);
            cmbSeat.Name = "cmbSeat";
            cmbSeat.Size = new Size(73, 28);
            cmbSeat.TabIndex = 5;
            // 
            // seatBindingSource
            // 
            seatBindingSource.DataSource = typeof(Models.Seat);
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
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
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
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 596);
            Controls.Add(cmbSeat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTicket);
            Controls.Add(dataGridViewTicketSchedule);
            Name = "TicketForm";
            Text = "Ticket";
            Load += TicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTicketSchedule;
        private BindingSource scheduleBindingSource;
        private Button btnTicket;
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
    }
}