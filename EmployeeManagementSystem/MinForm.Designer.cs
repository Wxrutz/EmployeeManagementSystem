namespace EmployeeManagementSystem
{
    partial class MinForm
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
            btnLogout = new Button();
            btnEmployee = new Button();
            btnSalaryReport = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(33, 546);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 39);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Navy;
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(23, 255);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(278, 44);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnSalaryReport
            // 
            btnSalaryReport.BackColor = Color.Navy;
            btnSalaryReport.ForeColor = Color.White;
            btnSalaryReport.Location = new Point(23, 409);
            btnSalaryReport.Name = "btnSalaryReport";
            btnSalaryReport.Size = new Size(278, 44);
            btnSalaryReport.TabIndex = 3;
            btnSalaryReport.Text = "SalaryReport";
            btnSalaryReport.UseVisualStyleBackColor = false;
            btnSalaryReport.Click += btnSalaryReport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 67);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnSalaryReport);
            panel2.Controls.Add(btnEmployee);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 597);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(346, 29);
            label1.TabIndex = 2;
            label1.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._530_5306663_large_format_business_administration_png_clipart;
            pictureBox1.Location = new Point(33, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 196);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 5;
            label2.Text = "Welcome,Admin";
            // 
            // MinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MinForm";
            Text = "MinForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnEmployee;
        private Button btnSalaryReport;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}