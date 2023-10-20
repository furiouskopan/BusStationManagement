namespace BusStationInterface.Forms
{
    partial class RouteDetailsEditForm
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
            cmbLocations = new ComboBox();
            txtRouteID = new TextBox();
            txtSequenceNumber = new TextBox();
            dateTimePickerTime = new DateTimePicker();
            txtDescription = new TextBox();
            txtRouteDetailID = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbLocations
            // 
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(38, 27);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(151, 28);
            cmbLocations.TabIndex = 0;
            // 
            // txtRouteID
            // 
            txtRouteID.Location = new Point(235, 20);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.Size = new Size(125, 27);
            txtRouteID.TabIndex = 1;
            // 
            // txtSequenceNumber
            // 
            txtSequenceNumber.Location = new Point(366, 20);
            txtSequenceNumber.Name = "txtSequenceNumber";
            txtSequenceNumber.Size = new Size(125, 27);
            txtSequenceNumber.TabIndex = 2;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Location = new Point(38, 61);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(250, 27);
            dateTimePickerTime.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(497, 20);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 4;
            // 
            // txtRouteDetailID
            // 
            txtRouteDetailID.Location = new Point(628, 20);
            txtRouteDetailID.Name = "txtRouteDetailID";
            txtRouteDetailID.Size = new Size(125, 27);
            txtRouteDetailID.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(659, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // RouteDetailsEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtRouteDetailID);
            Controls.Add(txtDescription);
            Controls.Add(dateTimePickerTime);
            Controls.Add(txtSequenceNumber);
            Controls.Add(txtRouteID);
            Controls.Add(cmbLocations);
            Name = "RouteDetailsEditForm";
            Text = "RouteDetailsEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLocations;
        private TextBox txtRouteID;
        private TextBox txtSequenceNumber;
        private DateTimePicker dateTimePickerTime;
        private TextBox txtDescription;
        private TextBox txtRouteDetailID;
        private Button btnSave;
    }
}