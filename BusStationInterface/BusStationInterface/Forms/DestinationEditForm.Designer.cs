namespace BusStationInterface.Forms
{
    partial class DestinationEditForm
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
            btnDeleteDestination = new Button();
            btnAddDestination = new Button();
            lblDescription = new Label();
            lblName = new Label();
            txtDestinationName = new TextBox();
            txtDestinationDescription = new TextBox();
            btnSaveDestinationEdit = new Button();
            dataGridViewDestinationsOnEditForm = new DataGridView();
            destinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationBindingSource = new BindingSource(components);
            groupboxAddDest = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinationsOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).BeginInit();
            groupboxAddDest.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteDestination
            // 
            btnDeleteDestination.BackColor = Color.Firebrick;
            btnDeleteDestination.ForeColor = Color.White;
            btnDeleteDestination.Location = new Point(204, 331);
            btnDeleteDestination.Name = "btnDeleteDestination";
            btnDeleteDestination.Size = new Size(159, 35);
            btnDeleteDestination.TabIndex = 22;
            btnDeleteDestination.Text = "Delete Selected Destination";
            btnDeleteDestination.UseVisualStyleBackColor = false;
            btnDeleteDestination.Click += btnDeleteDestination_Click;
            // 
            // btnAddDestination
            // 
            btnAddDestination.Location = new Point(250, 35);
            btnAddDestination.Name = "btnAddDestination";
            btnAddDestination.Size = new Size(101, 38);
            btnAddDestination.TabIndex = 21;
            btnAddDestination.Text = "Add Destination";
            btnAddDestination.UseVisualStyleBackColor = true;
            btnAddDestination.Click += btnAddDestination_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(131, 26);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // txtDestinationName
            // 
            txtDestinationName.Location = new Point(21, 44);
            txtDestinationName.Name = "txtDestinationName";
            txtDestinationName.Size = new Size(100, 23);
            txtDestinationName.TabIndex = 18;
            // 
            // txtDestinationDescription
            // 
            txtDestinationDescription.Location = new Point(131, 44);
            txtDestinationDescription.Name = "txtDestinationDescription";
            txtDestinationDescription.Size = new Size(100, 23);
            txtDestinationDescription.TabIndex = 17;
            // 
            // btnSaveDestinationEdit
            // 
            btnSaveDestinationEdit.BackColor = Color.LimeGreen;
            btnSaveDestinationEdit.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDestinationEdit.ForeColor = SystemColors.ControlText;
            btnSaveDestinationEdit.Location = new Point(130, 394);
            btnSaveDestinationEdit.Name = "btnSaveDestinationEdit";
            btnSaveDestinationEdit.Size = new Size(126, 44);
            btnSaveDestinationEdit.TabIndex = 16;
            btnSaveDestinationEdit.Text = "Save";
            btnSaveDestinationEdit.UseVisualStyleBackColor = false;
            btnSaveDestinationEdit.Click += btnSaveDestinationEdit_Click;
            // 
            // dataGridViewDestinationsOnEditForm
            // 
            dataGridViewDestinationsOnEditForm.AllowUserToResizeColumns = false;
            dataGridViewDestinationsOnEditForm.AllowUserToResizeRows = false;
            dataGridViewDestinationsOnEditForm.AutoGenerateColumns = false;
            dataGridViewDestinationsOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinationsOnEditForm.Columns.AddRange(new DataGridViewColumn[] { destinationIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewDestinationsOnEditForm.DataSource = destinationBindingSource;
            dataGridViewDestinationsOnEditForm.Location = new Point(12, 12);
            dataGridViewDestinationsOnEditForm.Name = "dataGridViewDestinationsOnEditForm";
            dataGridViewDestinationsOnEditForm.RowTemplate.Height = 25;
            dataGridViewDestinationsOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewDestinationsOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDestinationsOnEditForm.Size = new Size(367, 203);
            dataGridViewDestinationsOnEditForm.TabIndex = 15;
            // 
            // destinationIDDataGridViewTextBoxColumn
            // 
            destinationIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationID";
            destinationIDDataGridViewTextBoxColumn.HeaderText = "ID";
            destinationIDDataGridViewTextBoxColumn.Name = "destinationIDDataGridViewTextBoxColumn";
            destinationIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // destinationBindingSource
            // 
            destinationBindingSource.DataSource = typeof(Models.Destination);
            // 
            // groupboxAddDest
            // 
            groupboxAddDest.Controls.Add(btnAddDestination);
            groupboxAddDest.Controls.Add(txtDestinationDescription);
            groupboxAddDest.Controls.Add(txtDestinationName);
            groupboxAddDest.Controls.Add(lblDescription);
            groupboxAddDest.Controls.Add(lblName);
            groupboxAddDest.Location = new Point(12, 233);
            groupboxAddDest.Name = "groupboxAddDest";
            groupboxAddDest.Size = new Size(367, 92);
            groupboxAddDest.TabIndex = 23;
            groupboxAddDest.TabStop = false;
            groupboxAddDest.Text = "Insert";
            // 
            // DestinationEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(groupboxAddDest);
            Controls.Add(btnDeleteDestination);
            Controls.Add(btnSaveDestinationEdit);
            Controls.Add(dataGridViewDestinationsOnEditForm);
            Name = "DestinationEditForm";
            Text = "DestinationEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinationsOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).EndInit();
            groupboxAddDest.ResumeLayout(false);
            groupboxAddDest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteDestination;
        private Button btnAddDestination;
        private Label lblDescription;
        private Label lblName;
        private TextBox txtDestinationName;
        private TextBox txtDestinationDescription;
        private Button btnSaveDestinationEdit;
        private DataGridView dataGridViewDestinationsOnEditForm;
        private BindingSource destinationBindingSource;
        private GroupBox groupboxAddDest;
        private DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}