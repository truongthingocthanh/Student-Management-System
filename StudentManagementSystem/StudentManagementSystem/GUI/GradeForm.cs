using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem.BLL;
using StudentManagementSystem.Entity;
using StudentManagementSystem.Exceptions;

namespace StudentManagementSystem.GUI
{
    public partial class GradeForm : Form
    {
        private readonly GradeBLL gradeBLL = new GradeBLL();

        public GradeForm()
        {
            InitializeComponent();
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();
            LoadGrades();
        }

        private void LoadStudents()
        {
            try
            {
                DataTable dt = gradeBLL.GetStudents();
                cboStudent.DataSource = dt;
                cboStudent.DisplayMember = "FullName";
                cboStudent.ValueMember = "StudentID";
                cboStudent.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses()
        {
            try
            {
                DataTable dt = gradeBLL.GetAllCourses();
                cboCourse.DataSource = dt;
                cboCourse.DisplayMember = "CourseName";
                cboCourse.ValueMember = "CourseID";
                cboCourse.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrades()
        {
            try
            {
                DataTable dt = gradeBLL.GetAllGrades();
                dgvGrades.DataSource = dt;

                if (dgvGrades.Columns["StudentID"] is DataGridViewColumn colStdId)
                    colStdId.HeaderText = "Mã SV";
                if (dgvGrades.Columns["StudentName"] is DataGridViewColumn colName)
                    colName.HeaderText = "Tên SV";
                if (dgvGrades.Columns["CourseName"] is DataGridViewColumn colCourseName)
                    colCourseName.HeaderText = "Tên Môn";
                if (dgvGrades.Columns["Score"] is DataGridViewColumn colScore)
                    colScore.HeaderText = "Điểm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải bảng điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudent.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboCourse.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một môn học!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string scoreText = txtScore.Text.Trim();
            if (string.IsNullOrWhiteSpace(scoreText))
            {
                MessageBox.Show("Vui lòng nhập điểm!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
                return;
            }

            double score;
            if (!double.TryParse(scoreText, out score))
            {
                MessageBox.Show("Điểm thi phải là một số thực!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
                return;
            }

            string studentID = cboStudent.SelectedValue.ToString() ?? "";
            string courseID = cboCourse.SelectedValue.ToString() ?? "";

            try
            {
                Grade grade = new Grade
                {
                    StudentID = studentID,
                    CourseID = courseID,
                    Score = score
                };

                
                gradeBLL.SaveGrade(grade);

                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                txtScore.Clear();
                cboStudent.SelectedIndex = -1;
                cboCourse.SelectedIndex = -1;
                LoadGrades();
            }
            catch (DiemKhongHopLeException dex)
            {
                MessageBox.Show($"[Custom Exception] {dex.Message}", "Lỗi Điểm Số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtScore.Clear();

            if (cboStudent.DataSource != null)
                cboStudent.SelectedIndex = -1;

            if (cboCourse.DataSource != null)
                cboCourse.SelectedIndex = -1;

            dgvGrades.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa điểm sẽ xử lý sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGrades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrades.CurrentRow == null)
                return;

            if (dgvGrades.CurrentRow.IsNewRow)
                return;

            try
            {
                if (dgvGrades.CurrentRow.Cells["StudentID"].Value != null)
                {
                    cboStudent.SelectedValue = dgvGrades.CurrentRow.Cells["StudentID"].Value.ToString();
                }

                if (dgvGrades.Columns.Contains("CourseID") &&
                    dgvGrades.CurrentRow.Cells["CourseID"].Value != null)
                {
                    cboCourse.SelectedValue = dgvGrades.CurrentRow.Cells["CourseID"].Value.ToString();
                }

                if (dgvGrades.CurrentRow.Cells["Score"].Value != null)
                {
                    txtScore.Text = dgvGrades.CurrentRow.Cells["Score"].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
