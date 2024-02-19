namespace BusStationInterface.Forms
{
    partial class SimulationForm
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
            btnStartSimulation = new Button();
            cmbRoutes = new ComboBox();
            lstSimulationLog = new ListBox();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            remainingLabel = new Label();
            dataGridView1 = new DataGridView();
            btnStopSimulation = new Button();
            cmbSchedules = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnStartSimulation
            // 
            btnStartSimulation.Location = new Point(349, 214);
            btnStartSimulation.Name = "btnStartSimulation";
            btnStartSimulation.Size = new Size(75, 23);
            btnStartSimulation.TabIndex = 0;
            btnStartSimulation.Text = "button1";
            btnStartSimulation.UseVisualStyleBackColor = true;
            btnStartSimulation.Click += btnStartSimulation_Click;
            // 
            // cmbRoutes
            // 
            cmbRoutes.FormattingEnabled = true;
            cmbRoutes.Location = new Point(337, 87);
            cmbRoutes.Name = "cmbRoutes";
            cmbRoutes.Size = new Size(141, 23);
            cmbRoutes.TabIndex = 1;
            cmbRoutes.SelectedIndexChanged += cmbRoutes_SelectedIndexChanged;
            // 
            // lstSimulationLog
            // 
            lstSimulationLog.FormattingEnabled = true;
            lstSimulationLog.ItemHeight = 15;
            lstSimulationLog.Location = new Point(668, 78);
            lstSimulationLog.Name = "lstSimulationLog";
            lstSimulationLog.Size = new Size(120, 169);
            lstSimulationLog.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(230, 495);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(343, 23);
            progressBar.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer_Tick;
            // 
            // remainingLabel
            // 
            remainingLabel.AutoSize = true;
            remainingLabel.Location = new Point(64, 36);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new Size(38, 15);
            remainingLabel.TabIndex = 7;
            remainingLabel.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(292, 379);
            dataGridView1.TabIndex = 8;
            // 
            // btnStopSimulation
            // 
            btnStopSimulation.Location = new Point(448, 214);
            btnStopSimulation.Name = "btnStopSimulation";
            btnStopSimulation.Size = new Size(75, 23);
            btnStopSimulation.TabIndex = 9;
            btnStopSimulation.Text = "button1";
            btnStopSimulation.UseVisualStyleBackColor = true;
            btnStopSimulation.Click += btnStopSimulation_Click;
            // 
            // cmbSchedules
            // 
            cmbSchedules.FormattingEnabled = true;
            cmbSchedules.Location = new Point(337, 129);
            cmbSchedules.Name = "cmbSchedules";
            cmbSchedules.Size = new Size(141, 23);
            cmbSchedules.TabIndex = 10;
            cmbSchedules.SelectedIndexChanged += cmbSchedules_SelectedIndexChanged;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(cmbSchedules);
            Controls.Add(btnStopSimulation);
            Controls.Add(dataGridView1);
            Controls.Add(remainingLabel);
            Controls.Add(progressBar);
            Controls.Add(lstSimulationLog);
            Controls.Add(cmbRoutes);
            Controls.Add(btnStartSimulation);
            Name = "SimulationForm";
            Text = "SimulationForm";
            Load += SimulationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartSimulation;
        private ComboBox cmbRoutes;
        private ListBox lstSimulationLog;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private Label remainingLabel;
        private DataGridView dataGridView1;
        private Button btnStopSimulation;
        private ComboBox cmbSchedules;
    }
}