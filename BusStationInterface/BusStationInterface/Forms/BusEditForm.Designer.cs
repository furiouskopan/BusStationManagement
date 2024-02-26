namespace BusStationInterface
{
    partial class BusEditForm
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
            dataGridViewBusesOnEditForm = new DataGridView();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busBindingSource = new BindingSource(components);
            lblSeats = new Label();
            lblType = new Label();
            txtBusType = new TextBox();
            groupBox1 = new GroupBox();
            txtTotalSeats = new TextBox();
            btnAddBus = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            btnDeleteBus = new MaterialSkin.Controls.MaterialButton();
            btnSaveBusEdit = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBusesOnEditForm
            // 
            dataGridViewBusesOnEditForm.AllowUserToResizeColumns = false;
            dataGridViewBusesOnEditForm.AllowUserToResizeRows = false;
            dataGridViewBusesOnEditForm.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBusesOnEditForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBusesOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusesOnEditForm.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, busTypeDataGridViewTextBoxColumn, totalSeatsDataGridViewTextBoxColumn });
            dataGridViewBusesOnEditForm.DataSource = busBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewBusesOnEditForm.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBusesOnEditForm.Location = new Point(50, 69);
            dataGridViewBusesOnEditForm.MultiSelect = false;
            dataGridViewBusesOnEditForm.Name = "dataGridViewBusesOnEditForm";
            dataGridViewBusesOnEditForm.RowHeadersVisible = false;
            dataGridViewBusesOnEditForm.RowHeadersWidth = 51;
            dataGridViewBusesOnEditForm.RowTemplate.Height = 25;
            dataGridViewBusesOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewBusesOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBusesOnEditForm.Size = new Size(377, 206);
            dataGridViewBusesOnEditForm.TabIndex = 7;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "ID";
            busIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            busIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            busTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            busTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            busTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            totalSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            totalSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // busBindingSource
            // 
            busBindingSource.DataSource = typeof(Models.Bus);
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Location = new Point(150, 23);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(44, 20);
            lblSeats.TabIndex = 11;
            lblSeats.Text = "Seats";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(23, 23);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 10;
            lblType.Text = "Type";
            // 
            // txtBusType
            // 
            txtBusType.Location = new Point(23, 46);
            txtBusType.Name = "txtBusType";
            txtBusType.Size = new Size(100, 27);
            txtBusType.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalSeats);
            groupBox1.Controls.Add(txtBusType);
            groupBox1.Controls.Add(btnAddBus);
            groupBox1.Controls.Add(lblSeats);
            groupBox1.Controls.Add(lblType);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(50, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 98);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Location = new Point(150, 46);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(100, 27);
            txtTotalSeats.TabIndex = 2;
            // 
            // btnAddBus
            // 
            btnAddBus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddBus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddBus.Depth = 0;
            btnAddBus.HighEmphasis = true;
            btnAddBus.Icon = null;
            btnAddBus.Location = new Point(282, 41);
            btnAddBus.Margin = new Padding(4, 6, 4, 6);
            btnAddBus.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddBus.Name = "btnAddBus";
            btnAddBus.NoAccentTextColor = Color.Empty;
            btnAddBus.Size = new Size(82, 36);
            btnAddBus.TabIndex = 16;
            btnAddBus.Text = "Add Bus";
            btnAddBus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddBus.UseAccentColor = false;
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 15;
            label1.Text = "Edit Buses";
            // 
            // btnDeleteBus
            // 
            btnDeleteBus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteBus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteBus.Depth = 0;
            btnDeleteBus.HighEmphasis = true;
            btnDeleteBus.Icon = null;
            btnDeleteBus.Location = new Point(434, 332);
            btnDeleteBus.Margin = new Padding(4, 6, 4, 6);
            btnDeleteBus.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteBus.Name = "btnDeleteBus";
            btnDeleteBus.NoAccentTextColor = Color.Empty;
            btnDeleteBus.Size = new Size(105, 36);
            btnDeleteBus.TabIndex = 17;
            btnDeleteBus.Text = "Delete Bus";
            btnDeleteBus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteBus.UseAccentColor = false;
            btnDeleteBus.UseVisualStyleBackColor = true;
            btnDeleteBus.Click += btnDeleteBus_Click;
            // 
            // btnSaveBusEdit
            // 
            btnSaveBusEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveBusEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveBusEdit.Depth = 0;
            btnSaveBusEdit.HighEmphasis = true;
            btnSaveBusEdit.Icon = null;
            btnSaveBusEdit.Location = new Point(38, 415);
            btnSaveBusEdit.Margin = new Padding(4, 6, 4, 6);
            btnSaveBusEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveBusEdit.Name = "btnSaveBusEdit";
            btnSaveBusEdit.NoAccentTextColor = Color.Empty;
            btnSaveBusEdit.Size = new Size(64, 36);
            btnSaveBusEdit.TabIndex = 18;
            btnSaveBusEdit.Text = "Save";
            btnSaveBusEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveBusEdit.UseAccentColor = false;
            btnSaveBusEdit.UseVisualStyleBackColor = true;
            btnSaveBusEdit.Click += btnSaveBusEdit_Click;
            // 
            // BusEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1188, 575);
            Controls.Add(btnSaveBusEdit);
            Controls.Add(btnDeleteBus);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewBusesOnEditForm);
            Name = "BusEditForm";
            Text = "BusEditForm";
            Load += BusEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewBusesOnEditForm;
        private BindingSource busBindingSource;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private Label lblSeats;
        private Label lblType;
        private TextBox txtBusType;
        private GroupBox groupBox1;
        private TextBox txtTotalSeats;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnAddBus;
        private MaterialSkin.Controls.MaterialButton btnDeleteBus;
        private MaterialSkin.Controls.MaterialButton btnSaveBusEdit;
    }
}