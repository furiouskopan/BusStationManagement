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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridViewDriversOnEditForm.Location = new Point(14, 16);
            dataGridViewDriversOnEditForm.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDriversOnEditForm.Name = "dataGridViewDriversOnEditForm";
            dataGridViewDriversOnEditForm.RowHeadersWidth = 51;
            dataGridViewDriversOnEditForm.RowTemplate.Height = 25;
            dataGridViewDriversOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewDriversOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDriversOnEditForm.Size = new Size(381, 279);
            dataGridViewDriversOnEditForm.TabIndex = 0;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "ID";
            driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            contactInformationDataGridViewTextBoxColumn.DataPropertyName = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            contactInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // btnSaveDriverEdit
            // 
            btnSaveDriverEdit.BackColor = Color.LimeGreen;
            btnSaveDriverEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDriverEdit.ForeColor = SystemColors.ControlText;
            btnSaveDriverEdit.Location = new Point(129, 503);
            btnSaveDriverEdit.Margin = new Padding(3, 4, 3, 4);
            btnSaveDriverEdit.Name = "btnSaveDriverEdit";
            btnSaveDriverEdit.Size = new Size(144, 59);
            btnSaveDriverEdit.TabIndex = 1;
            btnSaveDriverEdit.Text = "Save";
            btnSaveDriverEdit.UseVisualStyleBackColor = false;
            btnSaveDriverEdit.Click += btnSaveDriverEdit_Click;
            // 
            // txtDriverContact
            // 
            txtDriverContact.Location = new Point(147, 52);
            txtDriverContact.Margin = new Padding(3, 4, 3, 4);
            txtDriverContact.Name = "txtDriverContact";
            txtDriverContact.Size = new Size(114, 27);
            txtDriverContact.TabIndex = 2;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(16, 52);
            txtDriverName.Margin = new Padding(3, 4, 3, 4);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(114, 27);
            txtDriverName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(147, 28);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(273, 40);
            btnAddDriver.Margin = new Padding(3, 4, 3, 4);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(101, 51);
            btnAddDriver.TabIndex = 6;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.BackColor = Color.Firebrick;
            btnDeleteDriver.ForeColor = Color.White;
            btnDeleteDriver.Location = new Point(225, 438);
            btnDeleteDriver.Margin = new Padding(3, 4, 3, 4);
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.Size = new Size(160, 57);
            btnDeleteDriver.TabIndex = 14;
            btnDeleteDriver.Text = "Delete Selected Driver";
            btnDeleteDriver.UseVisualStyleBackColor = false;
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddDriver);
            groupBox1.Controls.Add(txtDriverContact);
            groupBox1.Controls.Add(txtDriverName);
            groupBox1.Controls.Add(lblContact);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(11, 323);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(381, 115);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // DriverEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 577);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteDriver);
            Controls.Add(btnSaveDriverEdit);
            Controls.Add(dataGridViewDriversOnEditForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DriverEditForm";
            Text = "Edit Drivers";
            Load += DriverEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}