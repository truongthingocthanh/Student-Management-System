namespace StudentManagementSystem.GUI
{
    partial class GradeForm
    {
        
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


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
            picBanner = new PictureBox();
            panelInput = new Panel();
            btnReset = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtScore = new TextBox();
            lblScore = new Label();
            cboCourse = new ComboBox();
            lblCourse = new Label();
            cboStudent = new ComboBox();
            lblStudent = new Label();
            dgvGrades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // picBanner
            // 
            picBanner.Dock = DockStyle.Top;
            picBanner.Image = Properties.Resources.Ảnh_chụp_màn_hình_2026_07_03_174221;
            picBanner.Location = new Point(0, 0);
            picBanner.Margin = new Padding(4, 4, 4, 4);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(1062, 150);
            picBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picBanner.TabIndex = 0;
            picBanner.TabStop = false;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.FromArgb(248, 249, 250);
            panelInput.Controls.Add(btnReset);
            panelInput.Controls.Add(btnDelete);
            panelInput.Controls.Add(btnSave);
            panelInput.Controls.Add(txtScore);
            panelInput.Controls.Add(lblScore);
            panelInput.Controls.Add(cboCourse);
            panelInput.Controls.Add(lblCourse);
            panelInput.Controls.Add(cboStudent);
            panelInput.Controls.Add(lblStudent);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 150);
            panelInput.Margin = new Padding(4, 4, 4, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(400, 625);
            panelInput.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(38, 394);
            btnReset.Margin = new Padding(4, 4, 4, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(325, 50);
            btnReset.TabIndex = 8;
            btnReset.Text = "Hủy / Làm Mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(212, 325);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(38, 325);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu Điểm";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 10F);
            txtScore.Location = new Point(38, 244);
            txtScore.Margin = new Padding(4, 4, 4, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(324, 34);
            txtScore.TabIndex = 5;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.ForeColor = Color.FromArgb(33, 37, 41);
            lblScore.Location = new Point(38, 206);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(99, 28);
            lblScore.TabIndex = 4;
            lblScore.Text = "Điểm thi:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 10F);
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(38, 144);
            cboCourse.Margin = new Padding(4, 4, 4, 4);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(324, 36);
            cboCourse.TabIndex = 3;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(33, 37, 41);
            lblCourse.Location = new Point(38, 106);
            lblCourse.Margin = new Padding(4, 0, 4, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(153, 28);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Chọn môn học:";
            // 
            // cboStudent
            // 
            cboStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudent.Font = new Font("Segoe UI", 10F);
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(38, 56);
            cboStudent.Margin = new Padding(4, 4, 4, 4);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(324, 36);
            cboStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(33, 37, 41);
            lblStudent.Location = new Point(38, 19);
            lblStudent.Margin = new Padding(4, 0, 4, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(156, 28);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Chọn sinh viên:";
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.BackgroundColor = Color.White;
            dgvGrades.BorderStyle = BorderStyle.None;
            dgvGrades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrades.ColumnHeadersHeight = 40;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGrades.Dock = DockStyle.Fill;
            dgvGrades.EnableHeadersVisualStyles = false;
            dgvGrades.GridColor = Color.FromArgb(233, 236, 239);
            dgvGrades.Location = new Point(400, 150);
            dgvGrades.Margin = new Padding(4, 4, 4, 4);
            dgvGrades.MultiSelect = false;
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersVisible = false;
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.RowTemplate.Height = 35;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(662, 625);
            dgvGrades.TabIndex = 2;
            dgvGrades.SelectionChanged += dgvGrades_SelectionChanged;
            // 
            // GradeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 775);
            Controls.Add(dgvGrades);
            Controls.Add(panelInput);
            Controls.Add(picBanner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "GradeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Điểm Thi";
            Load += GradeForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvGrades;
    }
}
