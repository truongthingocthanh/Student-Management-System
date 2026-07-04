namespace StudentManagementSystem.GUI
{
    partial class CourseForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            picBanner = new PictureBox();
            panelInput = new Panel();
            btnReset = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtCredits = new TextBox();
            lblCredits = new Label();
            txtCourseName = new TextBox();
            lblCourseName = new Label();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            dgvCourses = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // picBanner
            // 
            picBanner.Dock = DockStyle.Top;
            picBanner.Location = new Point(0, 0);
            picBanner.Margin = new Padding(4);
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
            panelInput.Controls.Add(btnUpdate);
            panelInput.Controls.Add(btnAdd);
            panelInput.Controls.Add(txtCredits);
            panelInput.Controls.Add(lblCredits);
            panelInput.Controls.Add(txtCourseName);
            panelInput.Controls.Add(lblCourseName);
            panelInput.Controls.Add(txtCourseID);
            panelInput.Controls.Add(lblCourseID);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 150);
            panelInput.Margin = new Padding(4);
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
            btnReset.Location = new Point(212, 394);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 50);
            btnReset.TabIndex = 9;
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
            btnDelete.Location = new Point(38, 394);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(253, 126, 20);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(212, 325);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 50);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(13, 110, 253);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(38, 325);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCredits
            // 
            txtCredits.Font = new Font("Segoe UI", 10F);
            txtCredits.Location = new Point(38, 244);
            txtCredits.Margin = new Padding(4);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(324, 34);
            txtCredits.TabIndex = 5;
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCredits.ForeColor = Color.FromArgb(33, 37, 41);
            lblCredits.Location = new Point(38, 206);
            lblCredits.Margin = new Padding(4, 0, 4, 0);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(106, 28);
            lblCredits.TabIndex = 4;
            lblCredits.Text = "Số tín chỉ:";
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 10F);
            txtCourseName.Location = new Point(38, 144);
            txtCourseName.Margin = new Padding(4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(324, 34);
            txtCourseName.TabIndex = 3;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCourseName.ForeColor = Color.FromArgb(33, 37, 41);
            lblCourseName.Location = new Point(38, 106);
            lblCourseName.Margin = new Padding(4, 0, 4, 0);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(138, 28);
            lblCourseName.TabIndex = 2;
            lblCourseName.Text = "Tên môn học:";
            // 
            // txtCourseID
            // 
            txtCourseID.Font = new Font("Segoe UI", 10F);
            txtCourseID.Location = new Point(38, 56);
            txtCourseID.Margin = new Padding(4);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(324, 34);
            txtCourseID.TabIndex = 1;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCourseID.ForeColor = Color.FromArgb(33, 37, 41);
            lblCourseID.Location = new Point(38, 19);
            lblCourseID.Margin = new Padding(4, 0, 4, 0);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(135, 28);
            lblCourseID.TabIndex = 0;
            lblCourseID.Text = "Mã môn học:";
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCourses.ColumnHeadersHeight = 40;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.GridColor = Color.FromArgb(233, 236, 239);
            dgvCourses.Location = new Point(400, 150);
            dgvCourses.Margin = new Padding(4);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.Height = 35;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(662, 625);
            dgvCourses.TabIndex = 2;
            dgvCourses.SelectionChanged += dgvCourses_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 775);
            Controls.Add(dgvCourses);
            Controls.Add(panelInput);
            Controls.Add(picBanner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Môn Học";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvCourses;
        private ContextMenuStrip contextMenuStrip1;
    }
}