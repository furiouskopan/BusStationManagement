namespace BusStationInterface.Forms
{
    partial class RDForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStartDestination = new TextBox();
            txtEndDestination = new TextBox();
            txtDescription = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewRoutes = new DataGridView();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeBindingSource = new BindingSource(components);
            dataGridViewRouteDetails = new DataGridView();
            sequenceNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            routeDetailBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtRouteDetailDescription = new TextBox();
            txtSequenceNumber = new TextBox();
            txtLocation = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTime = new TextBox();
            label6 = new Label();
            btnAddRoute = new Button();
            btnAddRouteDetails = new Button();
            btnDeleteRoute = new Button();
            btnSaveRoutesEdit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRouteDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeDetailBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Start Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 1;
            label2.Text = "End Destination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // txtStartDestination
            // 
            txtStartDestination.Location = new Point(156, 38);
            txtStartDestination.Name = "txtStartDestination";
            txtStartDestination.Size = new Size(140, 29);
            txtStartDestination.TabIndex = 3;
            // 
            // txtEndDestination
            // 
            txtEndDestination.Location = new Point(156, 78);
            txtEndDestination.Name = "txtEndDestination";
            txtEndDestination.Size = new Size(140, 29);
            txtEndDestination.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(156, 117);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(140, 29);
            txtDescription.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStartDestination);
            groupBox1.Controls.Add(txtEndDestination);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Route";
            // 
            // dataGridViewRoutes
            // 
            dataGridViewRoutes.AllowUserToResizeColumns = false;
            dataGridViewRoutes.AllowUserToResizeRows = false;
            dataGridViewRoutes.AutoGenerateColumns = false;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewRoutes.DataSource = routeBindingSource;
            dataGridViewRoutes.Location = new Point(473, 38);
            dataGridViewRoutes.Name = "dataGridViewRoutes";
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.RowTemplate.Height = 25;
            dataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes.Size = new Size(304, 154);
            dataGridViewRoutes.TabIndex = 7;
            dataGridViewRoutes.SelectionChanged += dataGridViewRoutes_SelectionChanged;
            // 
            // startDestinationDataGridViewTextBoxColumn
            // 
            startDestinationDataGridViewTextBoxColumn.DataPropertyName = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.HeaderText = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.Name = "startDestinationDataGridViewTextBoxColumn";
            // 
            // endDestinationDataGridViewTextBoxColumn
            // 
            endDestinationDataGridViewTextBoxColumn.DataPropertyName = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.HeaderText = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.Name = "endDestinationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // routeBindingSource
            // 
            routeBindingSource.DataSource = typeof(Models.Route);
            // 
            // dataGridViewRouteDetails
            // 
            dataGridViewRouteDetails.AllowUserToResizeColumns = false;
            dataGridViewRouteDetails.AllowUserToResizeRows = false;
            dataGridViewRouteDetails.AutoGenerateColumns = false;
            dataGridViewRouteDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRouteDetails.Columns.AddRange(new DataGridViewColumn[] { sequenceNumberDataGridViewTextBoxColumn, Location, timeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn1 });
            dataGridViewRouteDetails.DataSource = routeDetailBindingSource;
            dataGridViewRouteDetails.Location = new Point(12, 232);
            dataGridViewRouteDetails.Name = "dataGridViewRouteDetails";
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.RowTemplate.Height = 25;
            dataGridViewRouteDetails.Size = new Size(403, 217);
            dataGridViewRouteDetails.TabIndex = 8;
            // 
            // sequenceNumberDataGridViewTextBoxColumn
            // 
            sequenceNumberDataGridViewTextBoxColumn.DataPropertyName = "SequenceNumber";
            sequenceNumberDataGridViewTextBoxColumn.HeaderText = "SequenceNumber";
            sequenceNumberDataGridViewTextBoxColumn.Name = "sequenceNumberDataGridViewTextBoxColumn";
            // 
            // Location
            // 
            Location.DataPropertyName = "LocationName";
            Location.HeaderText = "Location";
            Location.Name = "Location";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // routeDetailBindingSource
            // 
            routeDetailBindingSource.DataSource = typeof(Models.RouteDetail);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtRouteDetailDescription);
            groupBox2.Controls.Add(txtSequenceNumber);
            groupBox2.Controls.Add(txtLocation);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(446, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 217);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Route Detail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 157);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // txtRouteDetailDescription
            // 
            txtRouteDetailDescription.Location = new Point(167, 163);
            txtRouteDetailDescription.Name = "txtRouteDetailDescription";
            txtRouteDetailDescription.Size = new Size(140, 29);
            txtRouteDetailDescription.TabIndex = 7;
            // 
            // txtSequenceNumber
            // 
            txtSequenceNumber.Location = new Point(167, 42);
            txtSequenceNumber.Name = "txtSequenceNumber";
            txtSequenceNumber.Size = new Size(140, 29);
            txtSequenceNumber.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(167, 82);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(140, 29);
            txtLocation.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 115);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 2;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 76);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 1;
            label5.Text = "Location";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(167, 121);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(140, 29);
            txtTime.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 36);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 0;
            label6.Text = "Sequence Number";
            // 
            // btnAddRoute
            // 
            btnAddRoute.Location = new Point(357, 61);
            btnAddRoute.Name = "btnAddRoute";
            btnAddRoute.Size = new Size(85, 44);
            btnAddRoute.TabIndex = 10;
            btnAddRoute.Text = "Add Route";
            btnAddRoute.UseVisualStyleBackColor = true;
            btnAddRoute.Click += btnAddRoute_Click;
            // 
            // btnAddRouteDetails
            // 
            btnAddRouteDetails.Location = new Point(686, 430);
            btnAddRouteDetails.Name = "btnAddRouteDetails";
            btnAddRouteDetails.Size = new Size(85, 44);
            btnAddRouteDetails.TabIndex = 11;
            btnAddRouteDetails.Text = "Add Details";
            btnAddRouteDetails.UseVisualStyleBackColor = true;
            btnAddRouteDetails.Click += btnAddRouteDetails_Click;
            // 
            // btnDeleteRoute
            // 
            btnDeleteRoute.Location = new Point(357, 117);
            btnDeleteRoute.Name = "btnDeleteRoute";
            btnDeleteRoute.Size = new Size(85, 44);
            btnDeleteRoute.TabIndex = 12;
            btnDeleteRoute.Text = "Delete Route";
            btnDeleteRoute.UseVisualStyleBackColor = true;
            btnDeleteRoute.Click += btnDeleteRoute_Click;
            // 
            // btnSaveRoutesEdit
            // 
            btnSaveRoutesEdit.BackColor = Color.LimeGreen;
            btnSaveRoutesEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveRoutesEdit.ForeColor = SystemColors.ControlText;
            btnSaveRoutesEdit.Location = new Point(344, 508);
            btnSaveRoutesEdit.Name = "btnSaveRoutesEdit";
            btnSaveRoutesEdit.Size = new Size(126, 44);
            btnSaveRoutesEdit.TabIndex = 13;
            btnSaveRoutesEdit.Text = "Save";
            btnSaveRoutesEdit.UseVisualStyleBackColor = false;
            btnSaveRoutesEdit.Click += btnSaveRoutesEdit_Click;
            // 
            // RDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(btnSaveRoutesEdit);
            Controls.Add(btnDeleteRoute);
            Controls.Add(btnAddRouteDetails);
            Controls.Add(btnAddRoute);
            Controls.Add(groupBox2);
            Controls.Add(dataGridViewRouteDetails);
            Controls.Add(dataGridViewRoutes);
            Controls.Add(groupBox1);
            Name = "RDForm";
            Text = "RDForm";
            Load += RDForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRouteDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeDetailBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStartDestination;
        private TextBox txtEndDestination;
        private TextBox txtDescription;
        private GroupBox groupBox1;
        private DataGridView dataGridViewRoutes;
        private DataGridViewTextBoxColumn startDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource routeBindingSource;
        private DataGridView dataGridViewRouteDetails;
        private BindingSource routeDetailBindingSource;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtRouteDetailDescription;
        private TextBox txtSequenceNumber;
        private TextBox txtLocation;
        private Label label4;
        private Label label5;
        private TextBox txtTime;
        private Label label6;
        private Button btnAddRoute;
        private Button btnAddRouteDetails;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private Button btnDeleteRoute;
        private Button btnSaveRoutesEdit;
    }
}