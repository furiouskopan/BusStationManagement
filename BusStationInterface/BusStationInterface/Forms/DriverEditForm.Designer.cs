namespace BusStationInterface
{
    partial class DriverEditForm
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
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactInformationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverBindingSource = new BindingSource(components);
            btnSaveDriverEdit = new Button();
            txtDriverContact = new TextBox();
            txtDriverName = new TextBox();
            lblName = new Label();
            lblContact = new Label();
            btnAddDriver = new Button();
            btnDeleteDriver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDriversOnEditForm
            // 
            dataGridViewDriversOnEditForm.AllowUserToResizeColumns = false;
            dataGridViewDriversOnEditForm.AllowUserToResizeRows = false;
            dataGridViewDriversOnEditForm.AutoGenerateColumns = false;
            dataGridViewDriversOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDriversOnEditForm.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn });
            dataGridViewDriversOnEditForm.DataSource = driverBindingSource;
            dataGridViewDriversOnEditForm.Location = new Point(41, 12);
            dataGridViewDriversOnEditForm.Name = "dataGridViewDriversOnEditForm";
            dataGridViewDriversOnEditForm.RowTemplate.Height = 25;
            dataGridViewDriversOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewDriversOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDriversOnEditForm.Size = new Size(323, 150);
            dataGridViewDriversOnEditForm.TabIndex = 0;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "ID";
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            contactInformationDataGridViewTextBoxColumn.DataPropertyName = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // btnSaveDriverEdit
            // 
            btnSaveDriverEdit.Location = new Point(157, 362);
            btnSaveDriverEdit.Name = "btnSaveDriverEdit";
            btnSaveDriverEdit.Size = new Size(96, 34);
            btnSaveDriverEdit.TabIndex = 1;
            btnSaveDriverEdit.Text = "Save";
            btnSaveDriverEdit.UseVisualStyleBackColor = true;
            btnSaveDriverEdit.Click += btnSaveDriverEdit_Click;
            // 
            // txtDriverContact
            // 
            txtDriverContact.Location = new Point(157, 194);
            txtDriverContact.Name = "txtDriverContact";
            txtDriverContact.Size = new Size(100, 23);
            txtDriverContact.TabIndex = 2;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(42, 194);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(100, 23);
            txtDriverName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(42, 176);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(157, 176);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(49, 15);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(276, 185);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(88, 38);
            btnAddDriver.TabIndex = 6;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.BackColor = Color.Firebrick;
            btnDeleteDriver.ForeColor = Color.White;
            btnDeleteDriver.Location = new Point(241, 229);
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.Size = new Size(140, 35);
            btnDeleteDriver.TabIndex = 14;
            btnDeleteDriver.Text = "Delete Selected Driver";
            btnDeleteDriver.UseVisualStyleBackColor = false;
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // DriverEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 418);
            Controls.Add(btnDeleteDriver);
            Controls.Add(btnAddDriver);
            Controls.Add(lblContact);
            Controls.Add(lblName);
            Controls.Add(txtDriverName);
            Controls.Add(txtDriverContact);
            Controls.Add(btnSaveDriverEdit);
            Controls.Add(dataGridViewDriversOnEditForm);
            Name = "DriverEditForm";
            Text = "DriverEditForm";
            Load += DriverEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDriversOnEditForm;
        private BindingSource driverBindingSource;
        private Button btnSaveDriverEdit;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactInformationDataGridViewTextBoxColumn;
        private TextBox txtDriverContact;
        private TextBox txtDriverName;
        private Label lblName;
        private Label lblContact;
        private Button btnAddDriver;
        private Button btnDeleteDriver;
    }
}