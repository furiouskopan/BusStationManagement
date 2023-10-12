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
            schedulesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverBindingSource = new BindingSource(components);
            btnSaveDriverEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDriversOnEditForm
            // 
            dataGridViewDriversOnEditForm.AutoGenerateColumns = false;
            dataGridViewDriversOnEditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDriversOnEditForm.Columns.AddRange(new DataGridViewColumn[] { driverIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactInformationDataGridViewTextBoxColumn, schedulesDataGridViewTextBoxColumn });
            dataGridViewDriversOnEditForm.DataSource = driverBindingSource;
            dataGridViewDriversOnEditForm.Location = new Point(12, 12);
            dataGridViewDriversOnEditForm.Name = "dataGridViewDriversOnEditForm";
            dataGridViewDriversOnEditForm.RowTemplate.Height = 25;
            dataGridViewDriversOnEditForm.Size = new Size(459, 150);
            dataGridViewDriversOnEditForm.TabIndex = 0;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            contactInformationDataGridViewTextBoxColumn.DataPropertyName = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.HeaderText = "ContactInformation";
            contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Models.Driver);
            // 
            // btnSaveDriverEdit
            // 
            btnSaveDriverEdit.Location = new Point(713, 415);
            btnSaveDriverEdit.Name = "btnSaveDriverEdit";
            btnSaveDriverEdit.Size = new Size(75, 23);
            btnSaveDriverEdit.TabIndex = 1;
            btnSaveDriverEdit.Text = "Save";
            btnSaveDriverEdit.UseVisualStyleBackColor = true;
            btnSaveDriverEdit.Click += btnSaveDriverEdit_Click;
            // 
            // DriverEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveDriverEdit);
            Controls.Add(dataGridViewDriversOnEditForm);
            Name = "DriverEditForm";
            Text = "DriverEditForm";
            Load += DriverEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriversOnEditForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDriversOnEditForm;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactInformationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private BindingSource driverBindingSource;
        private Button btnSaveDriverEdit;
    }
}