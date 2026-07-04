using System;
using System.IO;
using System.Windows.Forms;
using StudentManagementSystem.DAL;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.GUI
{
    public partial class StudentForm : Form
    {
        private IStudentDAL studentDAL;

        public StudentForm()
        {
            InitializeComponent();
            studentDAL = new StudentDALSQLite();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            cboClass.Items.Clear();
            cboClass.Items.Add("LTHDT");
            cboClass.Items.Add("CTDLGT");
            cboClass.Items.Add("TTNT");
            cboClass.Items.Add("INF04224");
            cboClass.Items.Add("Toán rời rạc");
            cboClass.Items.Add("PPNCKH");

            if (cboClass.Items.Count > 0)
                cboClass.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = studentDAL.GetAll();

            if (!string.IsNullOrEmpty(studentDAL.GetError()))
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + studentDAL.GetError(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. CHỨC NĂNG THÊM SINH VIÊN
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter Student ID and Full Name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student newStudent = new Student
            {
                ID = txtStudentID.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Gender = rdoMale.Checked ? "Male" : "Female",
                DateOfBirth = dtpDateOfBirth.Value,
                ClassID = cboClass.SelectedItem?.ToString() ?? "Unknown",
                ImagePath = picStudent.Tag?.ToString()
            };

            if (studentDAL.Add(newStudent))
            {
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to add student. ID might already exist.\nDetails: " + studentDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. CHỨC NĂNG SỬA SINH VIÊN
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student from the list to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student updatedStudent = new Student
            {
                ID = txtStudentID.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Gender = rdoMale.Checked ? "Male" : "Female",
                DateOfBirth = dtpDateOfBirth.Value,
                ClassID = cboClass.SelectedItem?.ToString() ?? "Unknown",
                ImagePath = picStudent.Tag?.ToString()
            };

            if (studentDAL.Update(updatedStudent))
            {
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to update.\nDetails: " + studentDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. CHỨC NĂNG XÓA SINH VIÊN
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please select a student to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Student ID '{studentID}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (studentDAL.Delete(studentID))
                {
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to delete.\nDetails: " + studentDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. SỰ KIỆN CLICK VÀO LƯỚI - TỰ ĐỘNG THAY ĐỔI ẢNH THEO TỪNG NGƯỜI
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Student selectedStudent = dgvStudents.Rows[e.RowIndex].DataBoundItem as Student;

                if (selectedStudent != null)
                {
                    txtStudentID.Text = selectedStudent.ID;
                    txtFullName.Text = selectedStudent.FullName;
                    cboClass.Text = selectedStudent.ClassID;
                    dtpDateOfBirth.Value = selectedStudent.DateOfBirth;

                    if (selectedStudent.Gender == "Male" || selectedStudent.Gender == "Nam")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;

                    // XỬ LÝ ĐỔI ẢNH THÔNG MINH
                    picStudent.Image = null;
                    picStudent.Tag = selectedStudent.ImagePath;

                    if (!string.IsNullOrEmpty(selectedStudent.ImagePath) && File.Exists(selectedStudent.ImagePath))
                    {
                        try
                        {
                            picStudent.Image = System.Drawing.Image.FromFile(selectedStudent.ImagePath);
                            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch
                        {
                            picStudent.Image = null;
                        }
                    }
                }
            }
        }

        // 5. NÚT BROWSE PHOTO ĐỂ CHỌN ẢNH TỪ MÁY TÍNH
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh sinh viên";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                picStudent.Tag = openFileDialog.FileName;
            }
        }

        // 6. HÀM TIỆN ÍCH LÀM SẠCH FORM
        private void ClearForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            picStudent.Image = null;
            picStudent.Tag = null;
            dtpDateOfBirth.Value = DateTime.Now;
            if (cboClass.Items.Count > 0) cboClass.SelectedIndex = 0;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}