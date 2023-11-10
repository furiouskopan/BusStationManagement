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
            groupBox1 = new GroupBox();
            cmbEndDestination = new ComboBox();
            cmbStartDestination = new ComboBox();
            txtDescription = new TextBox();
            dataGridViewRoutes = new DataGridView();
            StartDestination = new DataGridViewTextBoxColumn();
            EndDestination = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeBindingSource = new BindingSource(components);
            dataGridViewRouteDetails = new DataGridView();
            SequenceNumber = new DataGridViewTextBoxColumn();
            RouteID = new DataGridViewTextBoxColumn();
            RouteDetailID = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            LocationID = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            PriceToNextStop = new DataGridViewTextBoxColumn();
            routeDetailBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtPriceToNextStop = new TextBox();
            cmbDetailLocation = new ComboBox();
            label7 = new Label();
            txtRouteDetailDescription = new TextBox();
            txtSequenceNumber = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTime = new TextBox();
            label6 = new Label();
            btnAddRoute = new Button();
            btnAddRouteDetails = new Button();
            btnDeleteRoute = new Button();
            btnSaveRoutesEdit = new Button();
            btnDeleteRouteDetail = new Button();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbEndDestination);
            groupBox1.Controls.Add(cmbStartDestination);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Route";
            // 
            // cmbEndDestination
            // 
            cmbEndDestination.FormattingEnabled = true;
            cmbEndDestination.Location = new Point(169, 76);
            cmbEndDestination.Name = "cmbEndDestination";
            cmbEndDestination.Size = new Size(140, 29);
            cmbEndDestination.TabIndex = 7;
            // 
            // cmbStartDestination
            // 
            cmbStartDestination.FormattingEnabled = true;
            cmbStartDestination.Location = new Point(169, 36);
            cmbStartDestination.Name = "cmbStartDestination";
            cmbStartDestination.Size = new Size(140, 29);
            cmbStartDestination.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(169, 115);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(140, 29);
            txtDescription.TabIndex = 5;
            // 
            // dataGridViewRoutes
            // 
            dataGridViewRoutes.AllowUserToAddRows = false;
            dataGridViewRoutes.AllowUserToDeleteRows = false;
            dataGridViewRoutes.AllowUserToResizeColumns = false;
            dataGridViewRoutes.AllowUserToResizeRows = false;
            dataGridViewRoutes.AutoGenerateColumns = false;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { StartDestination, EndDestination, descriptionDataGridViewTextBoxColumn });
            dataGridViewRoutes.DataSource = routeBindingSource;
            dataGridViewRoutes.Location = new Point(473, 38);
            dataGridViewRoutes.Name = "dataGridViewRoutes";
            dataGridViewRoutes.RowHeadersVisible = false;
            dataGridViewRoutes.RowHeadersWidth = 51;
            dataGridViewRoutes.RowTemplate.Height = 25;
            dataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes.Size = new Size(378, 154);
            dataGridViewRoutes.TabIndex = 7;
            dataGridViewRoutes.SelectionChanged += dataGridViewRoutes_SelectionChanged;
            // 
            // StartDestination
            // 
            StartDestination.DataPropertyName = "StartDestination";
            StartDestination.HeaderText = "StartDestination";
            StartDestination.MinimumWidth = 6;
            StartDestination.Name = "StartDestination";
            StartDestination.Width = 125;
            // 
            // EndDestination
            // 
            EndDestination.DataPropertyName = "EndDestination";
            EndDestination.HeaderText = "EndDestination";
            EndDestination.MinimumWidth = 6;
            EndDestination.Name = "EndDestination";
            EndDestination.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
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
            dataGridViewRouteDetails.Columns.AddRange(new DataGridViewColumn[] { SequenceNumber, RouteID, RouteDetailID, Location, LocationID, Time, Description, PriceToNextStop });
            dataGridViewRouteDetails.DataSource = routeDetailBindingSource;
            dataGridViewRouteDetails.Location = new Point(12, 232);
            dataGridViewRouteDetails.Name = "dataGridViewRouteDetails";
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.RowHeadersWidth = 51;
            dataGridViewRouteDetails.RowTemplate.Height = 25;
            dataGridViewRouteDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRouteDetails.Size = new Size(606, 217);
            dataGridViewRouteDetails.TabIndex = 8;
            // 
            // SequenceNumber
            // 
            SequenceNumber.DataPropertyName = "SequenceNumber";
            SequenceNumber.HeaderText = "SequenceNumber";
            SequenceNumber.MinimumWidth = 6;
            SequenceNumber.Name = "SequenceNumber";
            SequenceNumber.Width = 125;
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
            // RouteDetailID
            // 
            RouteDetailID.DataPropertyName = "RouteDetailID";
            RouteDetailID.HeaderText = "RouteDetailID";
            RouteDetailID.MinimumWidth = 6;
            RouteDetailID.Name = "RouteDetailID";
            RouteDetailID.Visible = false;
            RouteDetailID.Width = 125;
            // 
            // Location
            // 
            Location.DataPropertyName = "LocationName";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Width = 125;
            // 
            // LocationID
            // 
            LocationID.DataPropertyName = "LocationID";
            LocationID.HeaderText = "LocationID";
            LocationID.MinimumWidth = 6;
            LocationID.Name = "LocationID";
            LocationID.Visible = false;
            LocationID.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // PriceToNextStop
            // 
            PriceToNextStop.DataPropertyName = "PriceToNextStop";
            PriceToNextStop.HeaderText = "PriceToNextStop";
            PriceToNextStop.Name = "PriceToNextStop";
            // 
            // routeDetailBindingSource
            // 
            routeDetailBindingSource.DataSource = typeof(Models.RouteDetail);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPriceToNextStop);
            groupBox2.Controls.Add(cmbDetailLocation);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtRouteDetailDescription);
            groupBox2.Controls.Add(txtSequenceNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(642, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 248);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Route Detail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 201);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 9;
            label8.Text = "Price to next Stop";
            // 
            // txtPriceToNextStop
            // 
            txtPriceToNextStop.Location = new Point(178, 201);
            txtPriceToNextStop.Name = "txtPriceToNextStop";
            txtPriceToNextStop.Size = new Size(140, 29);
            txtPriceToNextStop.TabIndex = 10;
            // 
            // cmbDetailLocation
            // 
            cmbDetailLocation.FormattingEnabled = true;
            cmbDetailLocation.Location = new Point(178, 28);
            cmbDetailLocation.Name = "cmbDetailLocation";
            cmbDetailLocation.Size = new Size(140, 29);
            cmbDetailLocation.TabIndex = 8;
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
            txtRouteDetailDescription.Location = new Point(178, 157);
            txtRouteDetailDescription.Name = "txtRouteDetailDescription";
            txtRouteDetailDescription.Size = new Size(140, 29);
            txtRouteDetailDescription.TabIndex = 7;
            // 
            // txtSequenceNumber
            // 
            txtSequenceNumber.Location = new Point(178, 71);
            txtSequenceNumber.Name = "txtSequenceNumber";
            txtSequenceNumber.Size = new Size(140, 29);
            txtSequenceNumber.TabIndex = 3;
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
            label5.Location = new Point(25, 28);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 1;
            label5.Text = "Location";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(178, 115);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(140, 29);
            txtTime.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 71);
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
            btnAddRouteDetails.Location = new Point(875, 468);
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
            btnSaveRoutesEdit.Location = new Point(433, 533);
            btnSaveRoutesEdit.Name = "btnSaveRoutesEdit";
            btnSaveRoutesEdit.Size = new Size(126, 44);
            btnSaveRoutesEdit.TabIndex = 13;
            btnSaveRoutesEdit.Text = "Save";
            btnSaveRoutesEdit.UseVisualStyleBackColor = false;
            btnSaveRoutesEdit.Click += btnSaveRoutesEdit_Click;
            // 
            // btnDeleteRouteDetail
            // 
            btnDeleteRouteDetail.Location = new Point(648, 468);
            btnDeleteRouteDetail.Name = "btnDeleteRouteDetail";
            btnDeleteRouteDetail.Size = new Size(98, 44);
            btnDeleteRouteDetail.TabIndex = 12;
            btnDeleteRouteDetail.Text = "Delete Detail";
            btnDeleteRouteDetail.UseVisualStyleBackColor = true;
            btnDeleteRouteDetail.Click += btnDeleteRouteDetail_Click;
            // 
            // RDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 589);
            Controls.Add(btnDeleteRouteDetail);
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
        private GroupBox groupBox1;
        private DataGridView dataGridViewRoutes;
        private BindingSource routeBindingSource;
        private DataGridView dataGridViewRouteDetails;
        private BindingSource routeDetailBindingSource;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtRouteDetailDescription;
        private TextBox txtSequenceNumber;
        private Label label4;
        private Label label5;
        private TextBox txtTime;
        private Label label6;
        private Button btnAddRoute;
        private Button btnAddRouteDetails;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private Button btnDeleteRoute;
        private Button btnSaveRoutesEdit;
        private ComboBox cmbEndDestination;
        private ComboBox cmbStartDestination;
        private TextBox txtDescription;
        private ComboBox cmbDetailLocation;
        private Button btnDeleteRouteDetail;
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Descriptions;
        private DataGridViewTextBoxColumn StartDestination;
        private DataGridViewTextBoxColumn EndDestination;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Label label8;
        private TextBox txtPriceToNextStop;
        private DataGridViewTextBoxColumn SequenceNumber;
        private DataGridViewTextBoxColumn RouteID;
        private DataGridViewTextBoxColumn RouteDetailID;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn LocationID;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn PriceToNextStop;
    }
}