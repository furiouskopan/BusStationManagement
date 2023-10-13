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
            btnAddBus = new Button();
            lblSeats = new Label();
            lblType = new Label();
            txtBusType = new TextBox();
            txtTotalSeats = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSaveBusEdit
            // 
            btnSaveBusEdit.Location = new Point(147, 326);
            btnSaveBusEdit.Name = "btnSaveBusEdit";
            btnSaveBusEdit.Size = new Size(82, 26);
            btnSaveBusEdit.TabIndex = 6;
            btnSaveBusEdit.Text = "Save";
            btnSaveBusEdit.UseVisualStyleBackColor = true;
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
            dataGridViewBusesOnEditForm.Location = new Point(12, 12);
            dataGridViewBusesOnEditForm.Name = "dataGridViewBusesOnEditForm";
            dataGridViewBusesOnEditForm.RowTemplate.Height = 25;
            dataGridViewBusesOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewBusesOnEditForm.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewBusesOnEditForm.Size = new Size(387, 150);
            dataGridViewBusesOnEditForm.TabIndex = 7;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            busIDDataGridViewTextBoxColumn.HeaderText = "ID";
            busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            busTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            // 
            // busBindingSource
            // 
            busBindingSource.DataSource = typeof(Models.Bus);
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(278, 204);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(88, 38);
            btnAddBus.TabIndex = 12;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Location = new Point(159, 195);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(34, 15);
            lblSeats.TabIndex = 11;
            lblSeats.Text = "Seats";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(44, 195);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 10;
            lblType.Text = "Type";
            // 
            // txtBusType
            // 
            txtBusType.Location = new Point(44, 213);
            txtBusType.Name = "txtBusType";
            txtBusType.Size = new Size(100, 23);
            txtBusType.TabIndex = 9;
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Location = new Point(159, 213);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(100, 23);
            txtTotalSeats.TabIndex = 8;
            // 
            // BusEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 437);
            Controls.Add(btnAddBus);
            Controls.Add(lblSeats);
            Controls.Add(lblType);
            Controls.Add(txtBusType);
            Controls.Add(txtTotalSeats);
            Controls.Add(dataGridViewBusesOnEditForm);
            Controls.Add(btnSaveBusEdit);
            Name = "BusEditForm";
            Text = "BusEditForm";
            Load += BusEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)busBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSaveBusEdit;
        private DataGridView dataGridViewBusesOnEditForm;
        private BindingSource busBindingSource;
        private DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private Button btnAddBus;
        private Label lblSeats;
        private Label lblType;
        private TextBox txtBusType;
        private TextBox txtTotalSeats;
    }
}