namespace BusStationInterface.Forms
{
    partial class RouteEditForm
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
            dataGridViewDriversOnEditForm = new DataGridView();
            routeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDestinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            schedulesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeDetailsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routeBindingSource = new BindingSource(components);
            cmbStartDestinations = new ComboBox();
            cmbEndDestinations = new ComboBox();
            txtRouteID = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDriversOnEditForm
            // 
            dataGridViewDriversOnEditForm.AutoGenerateColumns = false;
            dataGridViewDriversOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDriversOnEditForm.Columns.AddRange(new DataGridViewColumn[] { routeIDDataGridViewTextBoxColumn, startDestinationIDDataGridViewTextBoxColumn, endDestinationIDDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, startDestinationDataGridViewTextBoxColumn, endDestinationDataGridViewTextBoxColumn, schedulesDataGridViewTextBoxColumn, routeDetailsDataGridViewTextBoxColumn });
            dataGridViewDriversOnEditForm.DataSource = routeBindingSource;
            dataGridViewDriversOnEditForm.Location = new Point(10, 9);
            dataGridViewDriversOnEditForm.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDriversOnEditForm.Name = "dataGridViewDriversOnEditForm";
            dataGridViewDriversOnEditForm.RowHeadersWidth = 51;
            dataGridViewDriversOnEditForm.RowTemplate.Height = 29;
            dataGridViewDriversOnEditForm.Size = new Size(925, 141);
            dataGridViewDriversOnEditForm.TabIndex = 0;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationIDDataGridViewTextBoxColumn
            // 
            startDestinationIDDataGridViewTextBoxColumn.DataPropertyName = "StartDestinationID";
            startDestinationIDDataGridViewTextBoxColumn.HeaderText = "StartDestinationID";
            startDestinationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationIDDataGridViewTextBoxColumn.Name = "startDestinationIDDataGridViewTextBoxColumn";
            startDestinationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationIDDataGridViewTextBoxColumn
            // 
            endDestinationIDDataGridViewTextBoxColumn.DataPropertyName = "EndDestinationID";
            endDestinationIDDataGridViewTextBoxColumn.HeaderText = "EndDestinationID";
            endDestinationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationIDDataGridViewTextBoxColumn.Name = "endDestinationIDDataGridViewTextBoxColumn";
            endDestinationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDestinationDataGridViewTextBoxColumn
            // 
            startDestinationDataGridViewTextBoxColumn.DataPropertyName = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.HeaderText = "StartDestination";
            startDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDestinationDataGridViewTextBoxColumn.Name = "startDestinationDataGridViewTextBoxColumn";
            startDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDestinationDataGridViewTextBoxColumn
            // 
            endDestinationDataGridViewTextBoxColumn.DataPropertyName = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.HeaderText = "EndDestination";
            endDestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDestinationDataGridViewTextBoxColumn.Name = "endDestinationDataGridViewTextBoxColumn";
            endDestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            schedulesDataGridViewTextBoxColumn.MinimumWidth = 6;
            schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            schedulesDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeDetailsDataGridViewTextBoxColumn
            // 
            routeDetailsDataGridViewTextBoxColumn.DataPropertyName = "RouteDetails";
            routeDetailsDataGridViewTextBoxColumn.HeaderText = "RouteDetails";
            routeDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            routeDetailsDataGridViewTextBoxColumn.Name = "routeDetailsDataGridViewTextBoxColumn";
            routeDetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeBindingSource
            // 
            routeBindingSource.DataSource = typeof(Models.Route);
            // 
            // cmbStartDestinations
            // 
            cmbStartDestinations.FormattingEnabled = true;
            cmbStartDestinations.Location = new Point(30, 166);
            cmbStartDestinations.Margin = new Padding(3, 2, 3, 2);
            cmbStartDestinations.Name = "cmbStartDestinations";
            cmbStartDestinations.Size = new Size(133, 23);
            cmbStartDestinations.TabIndex = 1;
            // 
            // cmbEndDestinations
            // 
            cmbEndDestinations.FormattingEnabled = true;
            cmbEndDestinations.Location = new Point(167, 166);
            cmbEndDestinations.Margin = new Padding(3, 2, 3, 2);
            cmbEndDestinations.Name = "cmbEndDestinations";
            cmbEndDestinations.Size = new Size(133, 23);
            cmbEndDestinations.TabIndex = 2;
            // 
            // txtRouteID
            // 
            txtRouteID.Location = new Point(318, 166);
            txtRouteID.Margin = new Padding(3, 2, 3, 2);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.Size = new Size(110, 23);
            txtRouteID.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(432, 166);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(841, 154);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 33);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // RouteEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 338);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtRouteID);
            Controls.Add(cmbEndDestinations);
            Controls.Add(cmbStartDestinations);
            Controls.Add(dataGridViewDriversOnEditForm);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RouteEditForm";
            Text = "RouteEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)routeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDriversOnEditForm;
        private DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDestinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routeDetailsDataGridViewTextBoxColumn;
        private BindingSource routeBindingSource;
        private ComboBox cmbStartDestinations;
        private ComboBox cmbEndDestinations;
        private TextBox txtRouteID;
        private TextBox txtDescription;
        private Button btnSave;
    }
}