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
            txtDriverContact = new TextBox();
            txtDriverName = new TextBox();
            lblName = new Label();
            lblContact = new Label();
            groupBox1 = new GroupBox();
            btnAddDriver = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            btnSaveDriverEdit = new MaterialSkin.Controls.MaterialButton();
            btnDeleteDriver = new MaterialSkin.Controls.MaterialButton();
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
            dataGridViewDriversOnEditForm.Location = new Point(36, 59);
            dataGridViewDriversOnEditForm.Name = "dataGridViewDriversOnEditForm";
            dataGridViewDriversOnEditForm.RowHeadersWidth = 51;
            dataGridViewDriversOnEditForm.RowTemplate.Height = 25;
            dataGridViewDriversOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewDriversOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDriversOnEditForm.Size = new Size(333, 209);
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
            // txtDriverContact
            // 
            txtDriverContact.Location = new Point(156, 39);
            txtDriverContact.Name = "txtDriverContact";
            txtDriverContact.Size = new Size(136, 23);
            txtDriverContact.TabIndex = 2;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(14, 39);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(136, 23);
            txtDriverName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(14, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblContact
            // 
            lblContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContact.Location = new Point(156, 19);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(92, 23);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddDriver);
            groupBox1.Controls.Add(txtDriverContact);
            groupBox1.Controls.Add(txtDriverName);
            groupBox1.Controls.Add(lblContact);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(36, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 86);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // btnAddDriver
            // 
            btnAddDriver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddDriver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddDriver.Depth = 0;
            btnAddDriver.HighEmphasis = true;
            btnAddDriver.Icon = null;
            btnAddDriver.Location = new Point(315, 31);
            btnAddDriver.Margin = new Padding(4, 6, 4, 6);
            btnAddDriver.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.NoAccentTextColor = Color.Empty;
            btnAddDriver.Size = new Size(104, 36);
            btnAddDriver.TabIndex = 19;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddDriver.UseAccentColor = false;
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 16;
            label1.Text = "Edit Drivers";
            // 
            // btnSaveDriverEdit
            // 
            btnSaveDriverEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveDriverEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveDriverEdit.Depth = 0;
            btnSaveDriverEdit.HighEmphasis = true;
            btnSaveDriverEdit.Icon = null;
            btnSaveDriverEdit.Location = new Point(165, 440);
            btnSaveDriverEdit.Margin = new Padding(4, 6, 4, 6);
            btnSaveDriverEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveDriverEdit.Name = "btnSaveDriverEdit";
            btnSaveDriverEdit.NoAccentTextColor = Color.Empty;
            btnSaveDriverEdit.Size = new Size(64, 36);
            btnSaveDriverEdit.TabIndex = 17;
            btnSaveDriverEdit.Text = "Save";
            btnSaveDriverEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveDriverEdit.UseAccentColor = false;
            btnSaveDriverEdit.UseVisualStyleBackColor = true;
            btnSaveDriverEdit.Click += btnSaveDriverEdit_Click;
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteDriver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteDriver.Depth = 0;
            btnDeleteDriver.HighEmphasis = true;
            btnDeleteDriver.Icon = null;
            btnDeleteDriver.Location = new Point(254, 396);
            btnDeleteDriver.Margin = new Padding(4, 6, 4, 6);
            btnDeleteDriver.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.NoAccentTextColor = Color.Empty;
            btnDeleteDriver.Size = new Size(127, 36);
            btnDeleteDriver.TabIndex = 18;
            btnDeleteDriver.Text = "Delete Driver";
            btnDeleteDriver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteDriver.UseAccentColor = false;
            btnDeleteDriver.UseVisualStyleBackColor = true;
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // DriverEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 501);
            Controls.Add(btnDeleteDriver);
            Controls.Add(btnSaveDriverEdit);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewDriversOnEditForm);
            Name = "DriverEditForm";
            Text = "Edit Drivers";
            Load += DriverEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDriversOnEditForm;
        private BindingSource driverBindingSource;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactInformationDataGridViewTextBoxColumn;
        private TextBox txtDriverContact;
        private TextBox txtDriverName;
        private Label lblName;
        private Label lblContact;
        private GroupBox groupBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnAddDriver;
        private MaterialSkin.Controls.MaterialButton btnSaveDriverEdit;
        private MaterialSkin.Controls.MaterialButton btnDeleteDriver;
    }
}