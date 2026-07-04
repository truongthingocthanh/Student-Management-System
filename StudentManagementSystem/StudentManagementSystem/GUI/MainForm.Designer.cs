namespace StudentManagementSystem
{
    partial class MainForm
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
<<<<<<< Updated upstream
            btnManageAccounts = new Button();
            btnManageStudents = new Button();
            SuspendLayout();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
=======
            menuStrip1 = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuManage = new ToolStripMenuItem();
            menuCourse = new ToolStripMenuItem();
            menuGrade = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
>>>>>>> Stashed changes
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem, menuManage });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 36);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(110, 32);
            menuSystem.Text = "Hệ thống";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(270, 36);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // menuManage
            // 
            menuManage.DropDownItems.AddRange(new ToolStripItem[] { menuCourse, menuGrade });
            menuManage.Name = "menuManage";
            menuManage.Size = new Size(95, 32);
            menuManage.Text = "Quản lý";
            // 
            // menuCourse
            // 
            menuCourse.Name = "menuCourse";
            menuCourse.Size = new Size(270, 36);
            menuCourse.Text = "Quản lý Môn Học";
            menuCourse.Click += menuCourse_Click;
            // 
            // menuGrade
            // 
<<<<<<< Updated upstream
            this.menuGrade.Name = "menuGrade";
            this.menuGrade.Size = new System.Drawing.Size(228, 28);
            this.menuGrade.Text = "Quản lý Điểm";
            this.menuGrade.Click += new System.EventHandler(this.menuGrade_Click);
            // 
            // btnManageAccounts
            // 
            btnManageAccounts.Location = new Point(12, 27);
            btnManageAccounts.Name = "btnManageAccounts";
            btnManageAccounts.Size = new Size(168, 34);
            btnManageAccounts.TabIndex = 0;
            btnManageAccounts.Text = "Manage Accounts";
            btnManageAccounts.UseVisualStyleBackColor = true;
            btnManageAccounts.Click += btnManageAccounts_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.Location = new Point(186, 27);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(163, 34);
            btnManageStudents.TabIndex = 1;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            this.flowLayoutPanel1.BackgroundImage = global::StudentManagementSystem.Properties.Resources.school;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 486);
            this.flowLayoutPanel1.TabIndex = 0;
=======
            menuGrade.Name = "menuGrade";
            menuGrade.Size = new Size(270, 36);
            menuGrade.Text = "Quản lý Điểm";
            menuGrade.Click += menuGrade_Click;
>>>>>>> Stashed changes
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 517);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Hệ thống Quản lý Sinh viên - Môn học";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 457);
            Controls.Add(btnManageStudents);
            Controls.Add(btnManageAccounts);
            Name = "MainForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuManage;
        private System.Windows.Forms.ToolStripMenuItem menuCourse;
        private System.Windows.Forms.ToolStripMenuItem menuGrade;
<<<<<<< Updated upstream
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Button btnManageAccounts;
        private Button btnManageStudents;
=======
>>>>>>> Stashed changes
    }
}
