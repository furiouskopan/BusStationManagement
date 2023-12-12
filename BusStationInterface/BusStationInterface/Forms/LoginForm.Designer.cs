namespace BusStationInterface.Forms
{
    partial class LoginForm
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label5 = new Label();
            btnLogin = new Button();
            panel4 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 411);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(141, 377);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 2;
            label3.Text = "Gorgi Kostov";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 360);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 1;
            label2.Text = "Developed by";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 140);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 0;
            label1.Text = "Bus Express";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo11;
            pictureBox1.Location = new Point(50, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 411);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(16, 296);
            button1.Name = "button1";
            button1.Size = new Size(96, 43);
            button1.TabIndex = 10;
            button1.Text = "seme";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(157, 22);
            label5.TabIndex = 3;
            label5.Text = "Strumica Station";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Brown;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(248, 344);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 46);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 40);
            panel4.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(42, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 24);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passwordicon;
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 40);
            panel3.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(42, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(330, 24);
            txtUsername.TabIndex = 7;
            txtUsername.Enter += txtUsername_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usericon1;
            pictureBox2.Location = new Point(6, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(135, 85);
            label4.Name = "label4";
            label4.Size = new Size(102, 39);
            label4.TabIndex = 4;
            label4.Text = "Login";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Brown;
            btnClose.Location = new Point(344, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(634, 411);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Label label4;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label5;
        private Button button1;
    }
}