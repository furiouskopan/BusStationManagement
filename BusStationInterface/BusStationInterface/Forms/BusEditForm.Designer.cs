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
            btnSaveBusEdit = new Button();
            dataGridViewBusesOnEditForm = new DataGridView();
            busIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            busBindingSource = new BindingSource(components);
            lblSeats = new Label();
            lblType = new Label();
            txtBusType = new TextBox();
            btnDeleteBus = new Button();
            groupBox1 = new GroupBox();
            btnAddBus = new Button();
            txtTotalSeats = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveBusEdit
            // 
            btnSaveBusEdit.BackColor = Color.LimeGreen;
            btnSaveBusEdit.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveBusEdit.Location = new Point(161, 508);
            btnSaveBusEdit.Margin = new Padding(3, 4, 3, 4);
            btnSaveBusEdit.Name = "btnSaveBusEdit";
            btnSaveBusEdit.Size = new Size(144, 59);
            btnSaveBusEdit.TabIndex = 6;
            btnSaveBusEdit.Text = "Save";
            btnSaveBusEdit.UseVisualStyleBackColor = false;
            btnSaveBusEdit.Click += btnSaveBusEdit_Click;
            // 
            // dataGridViewBusesOnEditForm
            // 
            dataGridViewBusesOnEditForm.AllowUserToResizeColumns = false;
            dataGridViewBusesOnEditForm.AllowUserToResizeRows = false;
            dataGridViewBusesOnEditForm.AutoGenerateColumns = false;
            dataGridViewBusesOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusesOnEditForm.Columns.AddRange(new DataGridViewColumn[] { busIDDataGridViewTextBoxColumn, busTypeDataGridViewTextBoxColumn, totalSeatsDataGridViewTextBoxColumn });
            dataGridViewBusesOnEditForm.DataSource = busBindingSource;
            dataGridViewBusesOnEditForm.Location = new Point(14, 16);
            dataGridViewBusesOnEditForm.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBusesOnEditForm.MultiSelect = false;
            dataGridViewBusesOnEditForm.Name = "dataGridViewBusesOnEditForm";
            dataGridViewBusesOnEditForm.RowHeadersWidth = 51;
            dataGridViewBusesOnEditForm.RowTemplate.Height = 25;
            dataGridViewBusesOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewBusesOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBusesOnEditForm.Size = new Size(442, 275);
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
            lblSeats.Location = new Point(147, 31);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(44, 20);
            lblSeats.TabIndex = 11;
            lblSeats.Text = "Seats";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(16, 31);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 10;
            lblType.Text = "Type";
            // 
            // txtBusType
            // 
            txtBusType.Location = new Point(16, 55);
            txtBusType.Margin = new Padding(3, 4, 3, 4);
            txtBusType.Name = "txtBusType";
            txtBusType.Size = new Size(114, 27);
            txtBusType.TabIndex = 9;
            // 
            // btnDeleteBus
            // 
            btnDeleteBus.BackColor = Color.Firebrick;
            btnDeleteBus.ForeColor = Color.White;
            btnDeleteBus.Location = new Point(297, 430);
            btnDeleteBus.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBus.Name = "btnDeleteBus";
            btnDeleteBus.Size = new Size(141, 57);
            btnDeleteBus.TabIndex = 13;
            btnDeleteBus.Text = "Delete Selected Bus";
            btnDeleteBus.UseVisualStyleBackColor = false;
            btnDeleteBus.Click += btnDeleteBus_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddBus);
            groupBox1.Controls.Add(txtTotalSeats);
            groupBox1.Controls.Add(txtBusType);
            groupBox1.Controls.Add(lblSeats);
            groupBox1.Controls.Add(lblType);
            groupBox1.Location = new Point(14, 311);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(442, 121);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(283, 43);
            btnAddBus.Margin = new Padding(3, 4, 3, 4);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(141, 51);
            btnAddBus.TabIndex = 12;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Location = new Point(147, 55);
            txtTotalSeats.Margin = new Padding(3, 4, 3, 4);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(114, 27);
            txtTotalSeats.TabIndex = 8;
            // 
            // BusEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 583);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteBus);
            Controls.Add(dataGridViewBusesOnEditForm);
            Controls.Add(btnSaveBusEdit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusEditForm";
            Text = "BusEditForm";
            Load += BusEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSaveBusEdit;
        private DataGridView dataGridViewBusesOnEditForm;
        private BindingSource busBindingSource;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private Label lblSeats;
        private Label lblType;
        private TextBox txtBusType;
        private Button btnDeleteBus;
        private GroupBox groupBox1;
        private Button btnAddBus;
        private TextBox txtTotalSeats;
    }
}