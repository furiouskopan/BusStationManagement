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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnDeleteRouteDetail = new MaterialSkin.Controls.MaterialButton();
            btnAddRouteDetails = new MaterialSkin.Controls.MaterialButton();
            btnSaveRoutesEdit = new MaterialSkin.Controls.MaterialButton();
            btnAddRoute = new MaterialSkin.Controls.MaterialButton();
            btnDeleteRoute = new MaterialSkin.Controls.MaterialButton();
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
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
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
            groupBox1.Location = new Point(67, 51);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRoutes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { StartDestination, EndDestination, descriptionDataGridViewTextBoxColumn });
            dataGridViewRoutes.DataSource = routeBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRoutes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRoutes.Location = new Point(778, 64);
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
            dataGridViewRouteDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRouteDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRouteDetails.Columns.AddRange(new DataGridViewColumn[] { SequenceNumber, RouteID, RouteDetailID, Location, LocationID, Time, Description, PriceToNextStop });
            dataGridViewRouteDetails.DataSource = routeDetailBindingSource;
            dataGridViewRouteDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRouteDetails.Location = new Point(67, 250);
            dataGridViewRouteDetails.Name = "dataGridViewRouteDetails";
            dataGridViewRouteDetails.RowHeadersVisible = false;
            dataGridViewRouteDetails.RowHeadersWidth = 51;
            dataGridViewRouteDetails.RowTemplate.Height = 25;
            dataGridViewRouteDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRouteDetails.Size = new Size(606, 217);
            dataGridViewRouteDetails.TabIndex = 8;
            dataGridViewRouteDetails.CellFormatting += dataGridViewRouteDetails_CellFormatting;
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
            groupBox2.Location = new Point(825, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 267);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Route Detail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 209);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 9;
            label8.Text = "Price to next Stop";
            // 
            // txtPriceToNextStop
            // 
            txtPriceToNextStop.Location = new Point(178, 206);
            txtPriceToNextStop.Name = "txtPriceToNextStop";
            txtPriceToNextStop.Size = new Size(140, 29);
            txtPriceToNextStop.TabIndex = 10;
            // 
            // cmbDetailLocation
            // 
            cmbDetailLocation.FormattingEnabled = true;
            cmbDetailLocation.Location = new Point(178, 33);
            cmbDetailLocation.Name = "cmbDetailLocation";
            cmbDetailLocation.Size = new Size(140, 29);
            cmbDetailLocation.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 162);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // txtRouteDetailDescription
            // 
            txtRouteDetailDescription.Location = new Point(178, 162);
            txtRouteDetailDescription.Name = "txtRouteDetailDescription";
            txtRouteDetailDescription.Size = new Size(140, 29);
            txtRouteDetailDescription.TabIndex = 7;
            // 
            // txtSequenceNumber
            // 
            txtSequenceNumber.Location = new Point(178, 76);
            txtSequenceNumber.Name = "txtSequenceNumber";
            txtSequenceNumber.Size = new Size(140, 29);
            txtSequenceNumber.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 120);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 2;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 33);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 1;
            label5.Text = "Location";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(178, 117);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(140, 29);
            txtTime.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 76);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 0;
            label6.Text = "Sequence Number";
            // 
            // btnDeleteRouteDetail
            // 
            btnDeleteRouteDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteRouteDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteRouteDetail.Depth = 0;
            btnDeleteRouteDetail.HighEmphasis = true;
            btnDeleteRouteDetail.Icon = null;
            btnDeleteRouteDetail.Location = new Point(1003, 507);
            btnDeleteRouteDetail.Margin = new Padding(4, 6, 4, 6);
            btnDeleteRouteDetail.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteRouteDetail.Name = "btnDeleteRouteDetail";
            btnDeleteRouteDetail.NoAccentTextColor = Color.Empty;
            btnDeleteRouteDetail.Size = new Size(126, 36);
            btnDeleteRouteDetail.TabIndex = 13;
            btnDeleteRouteDetail.Text = "Delete detail";
            btnDeleteRouteDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteRouteDetail.UseAccentColor = false;
            btnDeleteRouteDetail.UseVisualStyleBackColor = true;
            btnDeleteRouteDetail.Click += btnDeleteRouteDetail_Click;
            // 
            // btnAddRouteDetails
            // 
            btnAddRouteDetails.AutoSize = false;
            btnAddRouteDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRouteDetails.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRouteDetails.Depth = 0;
            btnAddRouteDetails.HighEmphasis = true;
            btnAddRouteDetails.Icon = null;
            btnAddRouteDetails.Location = new Point(850, 507);
            btnAddRouteDetails.Margin = new Padding(4, 6, 4, 6);
            btnAddRouteDetails.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddRouteDetails.Name = "btnAddRouteDetails";
            btnAddRouteDetails.NoAccentTextColor = Color.Empty;
            btnAddRouteDetails.Size = new Size(117, 36);
            btnAddRouteDetails.TabIndex = 14;
            btnAddRouteDetails.Text = "Add detail";
            btnAddRouteDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRouteDetails.UseAccentColor = false;
            btnAddRouteDetails.UseVisualStyleBackColor = true;
            btnAddRouteDetails.Click += btnAddRouteDetails_Click;
            // 
            // btnSaveRoutesEdit
            // 
            btnSaveRoutesEdit.AutoSize = false;
            btnSaveRoutesEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveRoutesEdit.Cursor = Cursors.Hand;
            btnSaveRoutesEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveRoutesEdit.Depth = 0;
            btnSaveRoutesEdit.HighEmphasis = true;
            btnSaveRoutesEdit.Icon = null;
            btnSaveRoutesEdit.Location = new Point(577, 527);
            btnSaveRoutesEdit.Margin = new Padding(4, 6, 4, 6);
            btnSaveRoutesEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveRoutesEdit.Name = "btnSaveRoutesEdit";
            btnSaveRoutesEdit.NoAccentTextColor = Color.Empty;
            btnSaveRoutesEdit.Size = new Size(210, 36);
            btnSaveRoutesEdit.TabIndex = 15;
            btnSaveRoutesEdit.Text = "Save";
            btnSaveRoutesEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveRoutesEdit.UseAccentColor = false;
            btnSaveRoutesEdit.UseVisualStyleBackColor = true;
            btnSaveRoutesEdit.Click += btnSaveRoutesEdit_Click;
            // 
            // btnAddRoute
            // 
            btnAddRoute.AutoSize = false;
            btnAddRoute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRoute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRoute.Depth = 0;
            btnAddRoute.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRoute.HighEmphasis = true;
            btnAddRoute.Icon = null;
            btnAddRoute.Location = new Point(550, 87);
            btnAddRoute.Margin = new Padding(4, 8, 4, 8);
            btnAddRoute.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddRoute.Name = "btnAddRoute";
            btnAddRoute.NoAccentTextColor = Color.Empty;
            btnAddRoute.Size = new Size(123, 36);
            btnAddRoute.TabIndex = 16;
            btnAddRoute.Text = "Add route";
            btnAddRoute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRoute.UseAccentColor = false;
            btnAddRoute.UseVisualStyleBackColor = true;
            btnAddRoute.Click += btnAddRoute_Click;
            // 
            // btnDeleteRoute
            // 
            btnDeleteRoute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteRoute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteRoute.Depth = 0;
            btnDeleteRoute.HighEmphasis = true;
            btnDeleteRoute.Icon = null;
            btnDeleteRoute.Location = new Point(550, 151);
            btnDeleteRoute.Margin = new Padding(4, 6, 4, 6);
            btnDeleteRoute.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteRoute.Name = "btnDeleteRoute";
            btnDeleteRoute.NoAccentTextColor = Color.Empty;
            btnDeleteRoute.Size = new Size(123, 36);
            btnDeleteRoute.TabIndex = 17;
            btnDeleteRoute.Text = "Delete route";
            btnDeleteRoute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteRoute.UseAccentColor = false;
            btnDeleteRoute.UseVisualStyleBackColor = true;
            btnDeleteRoute.Click += btnDeleteRoute_Click;
            // 
            // RDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 635);
            Controls.Add(btnDeleteRoute);
            Controls.Add(btnAddRoute);
            Controls.Add(btnSaveRoutesEdit);
            Controls.Add(btnAddRouteDetails);
            Controls.Add(btnDeleteRouteDetail);
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
            PerformLayout();
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
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private ComboBox cmbEndDestination;
        private ComboBox cmbStartDestination;
        private TextBox txtDescription;
        private ComboBox cmbDetailLocation;
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
        private MaterialSkin.Controls.MaterialButton btnDeleteRouteDetail;
        private MaterialSkin.Controls.MaterialButton btnAddRouteDetails;
        private MaterialSkin.Controls.MaterialButton btnSaveRoutesEdit;
        private MaterialSkin.Controls.MaterialButton btnAddRoute;
        private MaterialSkin.Controls.MaterialButton btnDeleteRoute;
    }
}