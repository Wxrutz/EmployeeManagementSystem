namespace EmployeeManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogout = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(755, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(32, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "X";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(384, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(354, 31);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(384, 199);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(354, 31);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(384, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(112, 47);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 450);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.participants;
            pictureBox1.Location = new Point(43, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Angsana New", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 307);
            label5.Name = "label5";
            label5.Size = new Size(206, 39);
            label5.TabIndex = 1;
            label5.Text = "ระบบจัดการงานบุคลากร";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 280);
            label4.Name = "label4";
            label4.Size = new Size(302, 27);
            label4.TabIndex = 0;
            label4.Text = "EmployeeManagementSystem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 90);
            label1.Name = "label1";
            label1.Size = new Size(214, 34);
            label1.TabIndex = 9;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 177);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 10;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 239);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 11;
            label3.Text = "Password :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(575, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 3;
            label6.Text = "version 1.0.0";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 450);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(btnLogout);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
