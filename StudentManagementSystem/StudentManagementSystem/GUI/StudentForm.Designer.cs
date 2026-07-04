namespace StudentManagementSystem.GUI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            dgvStudents = new DataGridView();
            Student_ID = new DataGridViewTextBoxColumn();
            Full_Name = new DataGridViewTextBoxColumn();
            Date_Of_Birth = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            txtStudentID = new TextBox();
            txtFullName = new TextBox();
            cboClass = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lbStudentID = new Label();
            lbFullName = new Label();
            lbDateOfBirth = new Label();
            lbClass = new Label();
            lbGender = new Label();
            picStudent = new PictureBox();
            btnUploadPhoto = new Button();
            openFileDialogPhoto = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.ScrollBar;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Student_ID, Full_Name, Date_Of_Birth, Class, Gender });
            dgvStudents.Dock = DockStyle.Bottom;
            dgvStudents.Location = new Point(0, 366);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1218, 251);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellClick += dgvStudents_CellClick;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // Student_ID
            // 
            Student_ID.DataPropertyName = "ID";
            Student_ID.HeaderText = "Student ID";
            Student_ID.MinimumWidth = 8;
            Student_ID.Name = "Student_ID";
            Student_ID.ReadOnly = true;
            // 
            // Full_Name
            // 
            Full_Name.DataPropertyName = "FullName";
            Full_Name.HeaderText = "Full Name";
            Full_Name.MinimumWidth = 8;
            Full_Name.Name = "Full_Name";
            Full_Name.ReadOnly = true;
            // 
            // Date_Of_Birth
            // 
            Date_Of_Birth.DataPropertyName = "DateOfBirth";
            Date_Of_Birth.HeaderText = "Date Of Birth";
            Date_Of_Birth.MinimumWidth = 8;
            Date_Of_Birth.Name = "Date_Of_Birth";
            Date_Of_Birth.ReadOnly = true;
            // 
            // Class
            // 
            Class.DataPropertyName = "ClassID";
            Class.HeaderText = "Class";
            Class.MinimumWidth = 8;
            Class.Name = "Class";
            Class.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(264, 22);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(211, 45);
            txtStudentID.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(264, 93);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(411, 45);
            txtFullName.TabIndex = 2;
            // 
            // cboClass
            // 
            cboClass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(264, 234);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(411, 46);
            cboClass.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Location = new Point(264, 164);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(411, 45);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMale.Location = new Point(264, 305);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(103, 42);
            rdoMale.TabIndex = 5;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoFemale.Location = new Point(410, 305);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(131, 42);
            rdoFemale.TabIndex = 6;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(815, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 192);
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(951, 320);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 40);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 64, 0);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1088, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbStudentID
            // 
            lbStudentID.AutoSize = true;
            lbStudentID.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStudentID.Location = new Point(21, 22);
            lbStudentID.Name = "lbStudentID";
            lbStudentID.Size = new Size(179, 45);
            lbStudentID.TabIndex = 10;
            lbStudentID.Text = "Student ID";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFullName.Location = new Point(21, 93);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(171, 45);
            lbFullName.TabIndex = 11;
            lbFullName.Text = "Full Name";
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateOfBirth.Location = new Point(21, 164);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(219, 45);
            lbDateOfBirth.TabIndex = 12;
            lbDateOfBirth.Text = "Date Of Birth";
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClass.Location = new Point(21, 235);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(94, 45);
            lbClass.TabIndex = 13;
            lbClass.Text = "Class";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGender.Location = new Point(21, 305);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(129, 45);
            lbGender.TabIndex = 14;
            lbGender.Text = "Gender";
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(893, 12);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(219, 217);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 15;
            picStudent.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(255, 192, 192);
            btnUploadPhoto.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadPhoto.Image = Properties.Resources.Camera;
            btnUploadPhoto.ImageAlign = ContentAlignment.MiddleLeft;
            btnUploadPhoto.Location = new Point(837, 235);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(321, 69);
            btnUploadPhoto.TabIndex = 16;
            btnUploadPhoto.Text = "Browse photo....\r\n";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // openFileDialogPhoto
            // 
            openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 617);
            Controls.Add(btnUploadPhoto);
            Controls.Add(picStudent);
            Controls.Add(lbGender);
            Controls.Add(lbClass);
            Controls.Add(lbDateOfBirth);
            Controls.Add(lbFullName);
            Controls.Add(lbStudentID);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cboClass);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentID);
            Controls.Add(dgvStudents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentForm";
            Text = "Student Management";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private ComboBox cboClass;
        private DateTimePicker dtpDateOfBirth;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lbStudentID;
        private Label lbFullName;
        private Label lbDateOfBirth;
        private Label lbClass;
        private Label lbGender;
        private PictureBox picStudent;
        private Button btnUploadPhoto;
        private OpenFileDialog openFileDialogPhoto;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Full_Name;
        private DataGridViewTextBoxColumn Date_Of_Birth;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Gender;
    }
}