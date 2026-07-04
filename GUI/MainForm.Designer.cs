namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLecturer = new System.Windows.Forms.Panel();
            this.pnlLecturerIndicator = new System.Windows.Forms.Panel();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.picLecturer = new System.Windows.Forms.PictureBox();
            this.pnlFaculty = new System.Windows.Forms.Panel();
            this.pnlFacultyIndicator = new System.Windows.Forms.Panel();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.picFaculty = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDashboardIndicator = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.flpBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLecturer)).BeginInit();
            this.pnlFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.pnlUser);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pnlBottom);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 672);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUser.Controls.Add(this.lblRole);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.picAvatar);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 170);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(230, 100);
            this.pnlUser.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.Silver;
            this.lblRole.Location = new System.Drawing.Point(104, 53);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(121, 25);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Administrator";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(129, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 30);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Admin";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::WindowsFormsApp1.Properties.Resources.download;
            this.picAvatar.Location = new System.Drawing.Point(30, 7);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lblSystem);
            this.pnlLogo.Controls.Add(this.lblUniversity);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 170);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSystem.Location = new System.Drawing.Point(15, 128);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(195, 28);
            this.lblSystem.TabIndex = 2;
            this.lblSystem.Text = "Management System";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.ForeColor = System.Drawing.Color.White;
            this.lblUniversity.Location = new System.Drawing.Point(14, 83);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(137, 36);
            this.lblUniversity.TabIndex = 1;
            this.lblUniversity.Text = "University";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.download__1_;
            this.picLogo.Location = new System.Drawing.Point(20, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenu.Controls.Add(this.pnlLecturer);
            this.pnlMenu.Controls.Add(this.pnlFaculty);
            this.pnlMenu.Controls.Add(this.pnlDashboard);
            this.pnlMenu.Location = new System.Drawing.Point(0, 270);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 282);
            this.pnlMenu.TabIndex = 2;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlLecturer
            // 
            this.pnlLecturer.Controls.Add(this.pnlLecturerIndicator);
            this.pnlLecturer.Controls.Add(this.lblLecturer);
            this.pnlLecturer.Controls.Add(this.picLecturer);
            this.pnlLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLecturer.Location = new System.Drawing.Point(0, 110);
            this.pnlLecturer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlLecturer.Name = "pnlLecturer";
            this.pnlLecturer.Size = new System.Drawing.Size(230, 55);
            this.pnlLecturer.TabIndex = 3;
            this.pnlLecturer.Click += new System.EventHandler(this.pnlLecturer_Click);
            // 
            // pnlLecturerIndicator
            // 
            this.pnlLecturerIndicator.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlLecturerIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLecturerIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlLecturerIndicator.Name = "pnlLecturerIndicator";
            this.pnlLecturerIndicator.Size = new System.Drawing.Size(8, 55);
            this.pnlLecturerIndicator.TabIndex = 2;
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.ForeColor = System.Drawing.Color.White;
            this.lblLecturer.Location = new System.Drawing.Point(60, 15);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(90, 28);
            this.lblLecturer.TabIndex = 1;
            this.lblLecturer.Text = "Lecturer";
            // 
            // picLecturer
            // 
            this.picLecturer.Image = global::WindowsFormsApp1.Properties.Resources.download__3_;
            this.picLecturer.Location = new System.Drawing.Point(20, 15);
            this.picLecturer.Name = "picLecturer";
            this.picLecturer.Size = new System.Drawing.Size(24, 24);
            this.picLecturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLecturer.TabIndex = 0;
            this.picLecturer.TabStop = false;
            // 
            // pnlFaculty
            // 
            this.pnlFaculty.Controls.Add(this.pnlFacultyIndicator);
            this.pnlFaculty.Controls.Add(this.lblFaculty);
            this.pnlFaculty.Controls.Add(this.picFaculty);
            this.pnlFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFaculty.Location = new System.Drawing.Point(0, 55);
            this.pnlFaculty.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlFaculty.Name = "pnlFaculty";
            this.pnlFaculty.Size = new System.Drawing.Size(230, 55);
            this.pnlFaculty.TabIndex = 2;
            this.pnlFaculty.Click += new System.EventHandler(this.pnlFaculty_Click);
            // 
            // pnlFacultyIndicator
            // 
            this.pnlFacultyIndicator.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlFacultyIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFacultyIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlFacultyIndicator.Name = "pnlFacultyIndicator";
            this.pnlFacultyIndicator.Size = new System.Drawing.Size(8, 55);
            this.pnlFacultyIndicator.TabIndex = 2;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.ForeColor = System.Drawing.Color.White;
            this.lblFaculty.Location = new System.Drawing.Point(60, 15);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(79, 28);
            this.lblFaculty.TabIndex = 1;
            this.lblFaculty.Text = "Faculty";
            // 
            // picFaculty
            // 
            this.picFaculty.Image = global::WindowsFormsApp1.Properties.Resources.download__5_;
            this.picFaculty.Location = new System.Drawing.Point(20, 15);
            this.picFaculty.Name = "picFaculty";
            this.picFaculty.Size = new System.Drawing.Size(24, 24);
            this.picFaculty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFaculty.TabIndex = 0;
            this.picFaculty.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pnlDashboardIndicator);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Controls.Add(this.picDashboard);
            this.pnlDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(230, 55);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.Click += new System.EventHandler(this.pnlDashboard_Click);
            // 
            // pnlDashboardIndicator
            // 
            this.pnlDashboardIndicator.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlDashboardIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboardIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardIndicator.Name = "pnlDashboardIndicator";
            this.pnlDashboardIndicator.Size = new System.Drawing.Size(8, 55);
            this.pnlDashboardIndicator.TabIndex = 2;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(60, 15);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(114, 28);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // picDashboard
            // 
            this.picDashboard.Image = global::WindowsFormsApp1.Properties.Resources.download__2_;
            this.picDashboard.Location = new System.Drawing.Point(20, 15);
            this.picDashboard.Name = "picDashboard";
            this.picDashboard.Size = new System.Drawing.Size(24, 24);
            this.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDashboard.TabIndex = 0;
            this.picDashboard.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.flpBottom);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 552);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(230, 120);
            this.pnlBottom.TabIndex = 1;
            // 
            // flpBottom
            // 
            this.flpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBottom.Location = new System.Drawing.Point(0, 0);
            this.flpBottom.Name = "flpBottom";
            this.flpBottom.Size = new System.Drawing.Size(230, 120);
            this.flpBottom.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(809, 70);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(47, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(203, 48);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pnlContainer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(809, 602);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(769, 562);
            this.pnlContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1039, 672);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLecturer.ResumeLayout(false);
            this.pnlLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLecturer)).EndInit();
            this.pnlFaculty.ResumeLayout(false);
            this.pnlFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.PictureBox picLecturer;
        private System.Windows.Forms.Panel pnlFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.PictureBox picFaculty;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlDashboardIndicator;
        private System.Windows.Forms.Panel pnlLecturerIndicator;
        private System.Windows.Forms.Panel pnlFacultyIndicator;
    }
}

