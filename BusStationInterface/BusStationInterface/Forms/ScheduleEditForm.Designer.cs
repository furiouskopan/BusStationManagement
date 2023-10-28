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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            btnAddSchedule = new Button();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Day = new Label();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 28);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 212);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 28);
            comboBox3.TabIndex = 12;
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
            // button2
            // 
            button2.Location = new Point(604, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(12, 422);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(11, 357);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 20;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(568, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(530, 225);
            dataGridView1.TabIndex = 23;
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
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 272);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(205, 28);
            comboBox4.TabIndex = 24;
            // 
            // ScheduleEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 583);
            Controls.Add(Day);
            Controls.Add(comboBox4);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnAddSchedule);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ScheduleEditForm";
            Text = "ScheduleEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button btnAddSchedule;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Label Day;
        private ComboBox comboBox4;
    }
}