namespace WindowsFormsApp1
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFaculty = new System.Windows.Forms.Panel();
            this.spMain = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFacultyTitle = new System.Windows.Forms.Label();
            this.lblFacultyCount = new System.Windows.Forms.Label();
            this.pnlLecturer = new System.Windows.Forms.Panel();
            this.lblLecturerCount = new System.Windows.Forms.Label();
            this.lblLecturerTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.lblCourseCount = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbRecentLecturer = new System.Windows.Forms.GroupBox();
            this.dgvRecentLecturer = new System.Windows.Forms.DataGridView();
            this.gbRecentFaculty = new System.Windows.Forms.GroupBox();
            this.dgvRecentFaculty = new System.Windows.Forms.DataGridView();
            this.colLecturerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalLecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpStatistics.SuspendLayout();
            this.pnlFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbRecentLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLecturer)).BeginInit();
            this.gbRecentFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // flpStatistics
            // 
            this.flpStatistics.BackColor = System.Drawing.Color.White;
            this.flpStatistics.Controls.Add(this.pnlFaculty);
            this.flpStatistics.Controls.Add(this.pnlLecturer);
            this.flpStatistics.Controls.Add(this.pnlCourse);
            this.flpStatistics.Controls.Add(this.pnlStudent);
            this.flpStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpStatistics.Location = new System.Drawing.Point(0, 0);
            this.flpStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpStatistics.Name = "flpStatistics";
            this.flpStatistics.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.flpStatistics.Size = new System.Drawing.Size(1148, 175);
            this.flpStatistics.TabIndex = 0;
            // 
            // pnlFaculty
            // 
            this.pnlFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFaculty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFaculty.Controls.Add(this.lblFacultyCount);
            this.pnlFaculty.Controls.Add(this.lblFacultyTitle);
            this.pnlFaculty.Controls.Add(this.pictureBox1);
            this.pnlFaculty.Location = new System.Drawing.Point(16, 18);
            this.pnlFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFaculty.Name = "pnlFaculty";
            this.pnlFaculty.Size = new System.Drawing.Size(268, 139);
            this.pnlFaculty.TabIndex = 1;
            // 
            // spMain
            // 
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.Location = new System.Drawing.Point(0, 175);
            this.spMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spMain.Name = "spMain";
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.gbRecentLecturer);
            this.spMain.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.gbRecentFaculty);
            this.spMain.Size = new System.Drawing.Size(1148, 704);
            this.spMain.SplitterDistance = 382;
            this.spMain.SplitterWidth = 5;
            this.spMain.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFacultyTitle
            // 
            this.lblFacultyTitle.AutoSize = true;
            this.lblFacultyTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyTitle.Location = new System.Drawing.Point(89, 21);
            this.lblFacultyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacultyTitle.Name = "lblFacultyTitle";
            this.lblFacultyTitle.Size = new System.Drawing.Size(102, 30);
            this.lblFacultyTitle.TabIndex = 1;
            this.lblFacultyTitle.Text = "Faculties";
            // 
            // lblFacultyCount
            // 
            this.lblFacultyCount.AutoSize = true;
            this.lblFacultyCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyCount.Location = new System.Drawing.Point(114, 64);
            this.lblFacultyCount.Name = "lblFacultyCount";
            this.lblFacultyCount.Size = new System.Drawing.Size(50, 60);
            this.lblFacultyCount.TabIndex = 2;
            this.lblFacultyCount.Text = "0";
            // 
            // pnlLecturer
            // 
            this.pnlLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlLecturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLecturer.Controls.Add(this.lblLecturerCount);
            this.pnlLecturer.Controls.Add(this.lblLecturerTitle);
            this.pnlLecturer.Controls.Add(this.pictureBox2);
            this.pnlLecturer.Location = new System.Drawing.Point(292, 18);
            this.pnlLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLecturer.Name = "pnlLecturer";
            this.pnlLecturer.Size = new System.Drawing.Size(268, 139);
            this.pnlLecturer.TabIndex = 2;
            // 
            // lblLecturerCount
            // 
            this.lblLecturerCount.AutoSize = true;
            this.lblLecturerCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerCount.Location = new System.Drawing.Point(114, 64);
            this.lblLecturerCount.Name = "lblLecturerCount";
            this.lblLecturerCount.Size = new System.Drawing.Size(50, 60);
            this.lblLecturerCount.TabIndex = 2;
            this.lblLecturerCount.Text = "0";
            // 
            // lblLecturerTitle
            // 
            this.lblLecturerTitle.AutoSize = true;
            this.lblLecturerTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerTitle.Location = new System.Drawing.Point(89, 21);
            this.lblLecturerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerTitle.Name = "lblLecturerTitle";
            this.lblLecturerTitle.Size = new System.Drawing.Size(109, 30);
            this.lblLecturerTitle.TabIndex = 1;
            this.lblLecturerTitle.Text = "Lecturers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 56);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCourse.Controls.Add(this.lblCourseCount);
            this.pnlCourse.Controls.Add(this.lblCourseTitle);
            this.pnlCourse.Controls.Add(this.pictureBox3);
            this.pnlCourse.Location = new System.Drawing.Point(568, 18);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(268, 139);
            this.pnlCourse.TabIndex = 3;
            // 
            // lblCourseCount
            // 
            this.lblCourseCount.AutoSize = true;
            this.lblCourseCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCount.Location = new System.Drawing.Point(114, 64);
            this.lblCourseCount.Name = "lblCourseCount";
            this.lblCourseCount.Size = new System.Drawing.Size(50, 60);
            this.lblCourseCount.TabIndex = 2;
            this.lblCourseCount.Text = "0";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(89, 21);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(94, 30);
            this.lblCourseTitle.TabIndex = 1;
            this.lblCourseTitle.Text = "Courses";
            this.lblCourseTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(18, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 56);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlStudent
            // 
            this.pnlStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudent.Controls.Add(this.lblStudentCount);
            this.pnlStudent.Controls.Add(this.lblStudentTitle);
            this.pnlStudent.Controls.Add(this.pictureBox4);
            this.pnlStudent.Location = new System.Drawing.Point(844, 18);
            this.pnlStudent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(268, 139);
            this.pnlStudent.TabIndex = 3;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.Location = new System.Drawing.Point(114, 64);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(50, 60);
            this.lblStudentCount.TabIndex = 2;
            this.lblStudentCount.Text = "0";
            // 
            // lblStudentTitle
            // 
            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentTitle.Location = new System.Drawing.Point(89, 21);
            this.lblStudentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(104, 30);
            this.lblStudentTitle.TabIndex = 1;
            this.lblStudentTitle.Text = "Students";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(18, 21);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 56);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // gbRecentLecturer
            // 
            this.gbRecentLecturer.Controls.Add(this.dgvRecentLecturer);
            this.gbRecentLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecentLecturer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecentLecturer.Location = new System.Drawing.Point(0, 0);
            this.gbRecentLecturer.Name = "gbRecentLecturer";
            this.gbRecentLecturer.Size = new System.Drawing.Size(382, 704);
            this.gbRecentLecturer.TabIndex = 0;
            this.gbRecentLecturer.TabStop = false;
            this.gbRecentLecturer.Text = "Recent Lecturers";
            // 
            // dgvRecentLecturer
            // 
            this.dgvRecentLecturer.AllowUserToAddRows = false;
            this.dgvRecentLecturer.AllowUserToDeleteRows = false;
            this.dgvRecentLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentLecturer.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentLecturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentLecturer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentLecturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentLecturer.ColumnHeadersHeight = 35;
            this.dgvRecentLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentLecturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLecturerID,
            this.colLecturerName,
            this.colDegree,
            this.colFaculty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentLecturer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentLecturer.EnableHeadersVisualStyles = false;
            this.dgvRecentLecturer.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRecentLecturer.Location = new System.Drawing.Point(3, 30);
            this.dgvRecentLecturer.MultiSelect = false;
            this.dgvRecentLecturer.Name = "dgvRecentLecturer";
            this.dgvRecentLecturer.ReadOnly = true;
            this.dgvRecentLecturer.RowHeadersVisible = false;
            this.dgvRecentLecturer.RowHeadersWidth = 62;
            this.dgvRecentLecturer.RowTemplate.Height = 32;
            this.dgvRecentLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentLecturer.Size = new System.Drawing.Size(376, 671);
            this.dgvRecentLecturer.TabIndex = 1;
            // 
            // gbRecentFaculty
            // 
            this.gbRecentFaculty.Controls.Add(this.dgvRecentFaculty);
            this.gbRecentFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecentFaculty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecentFaculty.Location = new System.Drawing.Point(0, 0);
            this.gbRecentFaculty.Name = "gbRecentFaculty";
            this.gbRecentFaculty.Size = new System.Drawing.Size(761, 704);
            this.gbRecentFaculty.TabIndex = 0;
            this.gbRecentFaculty.TabStop = false;
            this.gbRecentFaculty.Text = "Recent Faculties";
            // 
            // dgvRecentFaculty
            // 
            this.dgvRecentFaculty.AllowUserToAddRows = false;
            this.dgvRecentFaculty.AllowUserToDeleteRows = false;
            this.dgvRecentFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentFaculty.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentFaculty.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentFaculty.ColumnHeadersHeight = 35;
            this.dgvRecentFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacultyID,
            this.colFacultyName,
            this.colDean,
            this.colTotalLecturer});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentFaculty.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecentFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentFaculty.EnableHeadersVisualStyles = false;
            this.dgvRecentFaculty.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRecentFaculty.Location = new System.Drawing.Point(3, 30);
            this.dgvRecentFaculty.MultiSelect = false;
            this.dgvRecentFaculty.Name = "dgvRecentFaculty";
            this.dgvRecentFaculty.ReadOnly = true;
            this.dgvRecentFaculty.RowHeadersVisible = false;
            this.dgvRecentFaculty.RowHeadersWidth = 62;
            this.dgvRecentFaculty.RowTemplate.Height = 32;
            this.dgvRecentFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentFaculty.Size = new System.Drawing.Size(755, 671);
            this.dgvRecentFaculty.TabIndex = 0;
            // 
            // colLecturerID
            // 
            this.colLecturerID.HeaderText = "Lecturer ID";
            this.colLecturerID.MinimumWidth = 8;
            this.colLecturerID.Name = "colLecturerID";
            this.colLecturerID.ReadOnly = true;
            // 
            // colLecturerName
            // 
            this.colLecturerName.HeaderText = "Full Name";
            this.colLecturerName.MinimumWidth = 8;
            this.colLecturerName.Name = "colLecturerName";
            this.colLecturerName.ReadOnly = true;
            // 
            // colDegree
            // 
            this.colDegree.HeaderText = "Degree";
            this.colDegree.MinimumWidth = 8;
            this.colDegree.Name = "colDegree";
            this.colDegree.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.MinimumWidth = 8;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colFacultyID
            // 
            this.colFacultyID.HeaderText = "Faculty ID";
            this.colFacultyID.MinimumWidth = 8;
            this.colFacultyID.Name = "colFacultyID";
            this.colFacultyID.ReadOnly = true;
            // 
            // colFacultyName
            // 
            this.colFacultyName.HeaderText = "Faculty Name";
            this.colFacultyName.MinimumWidth = 8;
            this.colFacultyName.Name = "colFacultyName";
            this.colFacultyName.ReadOnly = true;
            // 
            // colDean
            // 
            this.colDean.HeaderText = "Dean";
            this.colDean.MinimumWidth = 8;
            this.colDean.Name = "colDean";
            this.colDean.ReadOnly = true;
            // 
            // colTotalLecturer
            // 
            this.colTotalLecturer.HeaderText = "Lecturers";
            this.colTotalLecturer.MinimumWidth = 8;
            this.colTotalLecturer.Name = "colTotalLecturer";
            this.colTotalLecturer.ReadOnly = true;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.spMain);
            this.Controls.Add(this.flpStatistics);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1148, 879);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.flpStatistics.ResumeLayout(false);
            this.pnlFaculty.ResumeLayout(false);
            this.pnlFaculty.PerformLayout();
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLecturer.ResumeLayout(false);
            this.pnlLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbRecentLecturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLecturer)).EndInit();
            this.gbRecentFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStatistics;
        private System.Windows.Forms.Panel pnlFaculty;
        private System.Windows.Forms.SplitContainer spMain;
        private System.Windows.Forms.Label lblFacultyCount;
        private System.Windows.Forms.Label lblFacultyTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.Label lblLecturerCount;
        private System.Windows.Forms.Label lblLecturerTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlCourse;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox gbRecentLecturer;
        private System.Windows.Forms.DataGridView dgvRecentLecturer;
        private System.Windows.Forms.GroupBox gbRecentFaculty;
        private System.Windows.Forms.DataGridView dgvRecentFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLecturerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLecturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDean;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalLecturer;
    }
}
