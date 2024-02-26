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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblDescription = new Label();
            lblName = new Label();
            txtDestinationName = new TextBox();
            txtDestinationDescription = new TextBox();
            dataGridViewDestinationsOnEditForm = new DataGridView();
            destinationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationBindingSource = new BindingSource(components);
            groupboxAddDest = new GroupBox();
            btnAddDestination = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            btnSaveDestinationEdit = new MaterialSkin.Controls.MaterialButton();
            btnDeleteDestination = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinationsOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).BeginInit();
            groupboxAddDest.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(172, 23);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // txtDestinationName
            // 
            txtDestinationName.Location = new Point(21, 44);
            txtDestinationName.Name = "txtDestinationName";
            txtDestinationName.Size = new Size(145, 27);
            txtDestinationName.TabIndex = 1;
            // 
            // txtDestinationDescription
            // 
            txtDestinationDescription.Location = new Point(172, 44);
            txtDestinationDescription.Name = "txtDestinationDescription";
            txtDestinationDescription.Size = new Size(145, 27);
            txtDestinationDescription.TabIndex = 2;
            // 
            // dataGridViewDestinationsOnEditForm
            // 
            dataGridViewDestinationsOnEditForm.AllowUserToResizeColumns = false;
            dataGridViewDestinationsOnEditForm.AllowUserToResizeRows = false;
            dataGridViewDestinationsOnEditForm.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDestinationsOnEditForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDestinationsOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinationsOnEditForm.Columns.AddRange(new DataGridViewColumn[] { destinationIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewDestinationsOnEditForm.DataSource = destinationBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDestinationsOnEditForm.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDestinationsOnEditForm.Location = new Point(50, 69);
            dataGridViewDestinationsOnEditForm.Name = "dataGridViewDestinationsOnEditForm";
            dataGridViewDestinationsOnEditForm.RowHeadersVisible = false;
            dataGridViewDestinationsOnEditForm.RowTemplate.Height = 25;
            dataGridViewDestinationsOnEditForm.ScrollBars = ScrollBars.Vertical;
            dataGridViewDestinationsOnEditForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDestinationsOnEditForm.Size = new Size(307, 206);
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
            groupboxAddDest.Controls.Add(txtDestinationDescription);
            groupboxAddDest.Controls.Add(btnAddDestination);
            groupboxAddDest.Controls.Add(txtDestinationName);
            groupboxAddDest.Controls.Add(lblDescription);
            groupboxAddDest.Controls.Add(lblName);
            groupboxAddDest.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupboxAddDest.Location = new Point(50, 290);
            groupboxAddDest.Name = "groupboxAddDest";
            groupboxAddDest.Size = new Size(562, 98);
            groupboxAddDest.TabIndex = 23;
            groupboxAddDest.TabStop = false;
            groupboxAddDest.Text = "Insert";
            // 
            // btnAddDestination
            // 
            btnAddDestination.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddDestination.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddDestination.Depth = 0;
            btnAddDestination.HighEmphasis = true;
            btnAddDestination.Icon = null;
            btnAddDestination.Location = new Point(324, 39);
            btnAddDestination.Margin = new Padding(4, 6, 4, 6);
            btnAddDestination.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddDestination.Name = "btnAddDestination";
            btnAddDestination.NoAccentTextColor = Color.Empty;
            btnAddDestination.Size = new Size(148, 36);
            btnAddDestination.TabIndex = 26;
            btnAddDestination.Text = "Add Destination";
            btnAddDestination.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddDestination.UseAccentColor = false;
            btnAddDestination.UseVisualStyleBackColor = true;
            btnAddDestination.Click += btnAddDestination_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(217, 37);
            label1.TabIndex = 24;
            label1.Text = "Edit Destinations";
            // 
            // btnSaveDestinationEdit
            // 
            btnSaveDestinationEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveDestinationEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveDestinationEdit.Depth = 0;
            btnSaveDestinationEdit.HighEmphasis = true;
            btnSaveDestinationEdit.Icon = null;
            btnSaveDestinationEdit.Location = new Point(38, 415);
            btnSaveDestinationEdit.Margin = new Padding(4, 6, 4, 6);
            btnSaveDestinationEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveDestinationEdit.Name = "btnSaveDestinationEdit";
            btnSaveDestinationEdit.NoAccentTextColor = Color.Empty;
            btnSaveDestinationEdit.Size = new Size(64, 36);
            btnSaveDestinationEdit.TabIndex = 25;
            btnSaveDestinationEdit.Text = "Save";
            btnSaveDestinationEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveDestinationEdit.UseAccentColor = false;
            btnSaveDestinationEdit.UseVisualStyleBackColor = true;
            btnSaveDestinationEdit.Click += btnSaveDestinationEdit_Click;
            // 
            // btnDeleteDestination
            // 
            btnDeleteDestination.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteDestination.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteDestination.Depth = 0;
            btnDeleteDestination.HighEmphasis = true;
            btnDeleteDestination.Icon = null;
            btnDeleteDestination.Location = new Point(530, 330);
            btnDeleteDestination.Margin = new Padding(4, 6, 4, 6);
            btnDeleteDestination.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteDestination.Name = "btnDeleteDestination";
            btnDeleteDestination.NoAccentTextColor = Color.Empty;
            btnDeleteDestination.Size = new Size(171, 36);
            btnDeleteDestination.TabIndex = 27;
            btnDeleteDestination.Text = "Delete Destination";
            btnDeleteDestination.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteDestination.UseAccentColor = false;
            btnDeleteDestination.UseVisualStyleBackColor = true;
            btnDeleteDestination.Click += btnDeleteDestination_Click;
            // 
            // DestinationEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 575);
            Controls.Add(btnDeleteDestination);
            Controls.Add(btnSaveDestinationEdit);
            Controls.Add(label1);
            Controls.Add(groupboxAddDest);
            Controls.Add(dataGridViewDestinationsOnEditForm);
            Name = "DestinationEditForm";
            Text = "DestinationEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinationsOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)destinationBindingSource).EndInit();
            groupboxAddDest.ResumeLayout(false);
            groupboxAddDest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDescription;
        private Label lblName;
        private TextBox txtDestinationName;
        private TextBox txtDestinationDescription;
        private DataGridView dataGridViewDestinationsOnEditForm;
        private BindingSource destinationBindingSource;
        private GroupBox groupboxAddDest;
        private DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnAddDestination;
        private MaterialSkin.Controls.MaterialButton btnSaveDestinationEdit;
        private MaterialSkin.Controls.MaterialButton btnDeleteDestination;
    }
}