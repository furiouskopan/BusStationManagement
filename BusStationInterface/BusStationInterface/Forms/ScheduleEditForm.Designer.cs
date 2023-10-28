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
            Day = new Label();
            cmbDay = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 26);
            label3.Name = "label3";
            label3.Size = new Size(176, 34);
            label3.TabIndex = 8;
            label3.Text = "Add Shedule";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(581, 26);
            label1.Name = "label1";
            label1.Size = new Size(197, 34);
            label1.TabIndex = 9;
            label1.Text = "Edit Schedules";
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(12, 104);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(205, 28);
            cmbRoute.TabIndex = 10;
            // 
            // cmbDriver
            // 
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(12, 158);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(205, 28);
            cmbDriver.TabIndex = 11;
            // 
            // cmbBus
            // 
            cmbBus.FormattingEnabled = true;
            cmbBus.Location = new Point(12, 212);
            cmbBus.Name = "cmbBus";
            cmbBus.Size = new Size(205, 28);
            cmbBus.TabIndex = 12;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(11, 455);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(124, 54);
            btnAddSchedule.TabIndex = 13;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(604, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 45);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 15;
            label2.Text = "Route";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 189);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 16;
            label4.Text = "Bus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 135);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "Driver";
            // 
            // dtpArrivalTime
            // 
            dtpArrivalTime.Format = DateTimePickerFormat.Time;
            dtpArrivalTime.Location = new Point(12, 422);
            dtpArrivalTime.Name = "dtpArrivalTime";
            dtpArrivalTime.Size = new Size(250, 27);
            dtpArrivalTime.TabIndex = 19;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.Format = DateTimePickerFormat.Time;
            dtpDepartureTime.Location = new Point(11, 357);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(250, 27);
            dtpDepartureTime.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 334);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 21;
            label7.Text = "Departure time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 399);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 22;
            label8.Text = "Arrival Time";
            // 
            // dgvSchedules
            // 
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(568, 64);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.RowTemplate.Height = 29;
            dgvSchedules.Size = new Size(530, 225);
            dgvSchedules.TabIndex = 23;
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.Location = new Point(11, 249);
            Day.Name = "Day";
            Day.Size = new Size(35, 20);
            Day.TabIndex = 25;
            Day.Text = "Day";
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(12, 272);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(205, 28);
            cmbDay.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(756, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 45);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnAddSchedule_Click;
            // 
            // ScheduleEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 583);
            Controls.Add(btnDelete);
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
            Name = "ScheduleEditForm";
            Text = "ScheduleEditForm";
            Load += ScheduleEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
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
        private Button btnDelete;
    }
}