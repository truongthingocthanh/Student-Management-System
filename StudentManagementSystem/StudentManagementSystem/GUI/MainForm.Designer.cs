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
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(96, 27);
            this.menuSystem.Text = "Hệ thống";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(137, 28);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCourse,
            this.menuGrade});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(83, 27);
            this.menuManage.Text = "Quản lý";
            // 
            // menuCourse
            // 
            this.menuCourse.Name = "menuCourse";
            this.menuCourse.Size = new System.Drawing.Size(228, 28);
            this.menuCourse.Text = "Quản lý Môn Học";
            this.menuCourse.Click += new System.EventHandler(this.menuCourse_Click);
            // 
            // menuGrade
            // 
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 517);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hệ thống Quản lý Sinh viên - Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Button btnManageAccounts;
        private Button btnManageStudents;
    }
}
