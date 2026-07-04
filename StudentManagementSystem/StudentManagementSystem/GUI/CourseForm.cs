using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using StudentManagementSystem.BLL;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.GUI
{
    public partial class CourseForm : Form
    {
        private readonly CourseBLL courseBLL = new CourseBLL();
        private bool isBinding = false;

        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadBanner();
            LoadCourses();
            ResetForm();
        }

        private void LoadBanner()
        {
            try
            {
                string bannerPath = Path.Combine(Application.StartupPath, "Resources", "course_banner.png");
                if (File.Exists(bannerPath))
                {
                    picBanner.Image = Image.FromFile(bannerPath);
                }
                else
                {
                    picBanner.BackColor = Color.SteelBlue;
                }
            }
            catch (Exception)
            {
                picBanner.BackColor = Color.SteelBlue;
            }
        }

        private void LoadCourses()
        {
            try
            {
                isBinding = true;
                DataTable dt = courseBLL.GetAllCourses();
                dgvCourses.DataSource = dt;

                if (dgvCourses.Columns["CourseID"] is DataGridViewColumn colId)
                    colId.HeaderText = "Mã Môn";
                if (dgvCourses.Columns["CourseName"] is DataGridViewColumn colName)
                    colName.HeaderText = "Tên Môn";
                if (dgvCourses.Columns["Credits"] is DataGridViewColumn colCreds)
                    colCreds.HeaderText = "Số Tín Chỉ";
                
                isBinding = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isBinding = false;
            }
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (isBinding) return;

            if (dgvCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCourses.SelectedRows[0];
                txtCourseID.Text = row.Cells["CourseID"].Value?.ToString() ?? "";
                txtCourseName.Text = row.Cells["CourseName"].Value?.ToString() ?? "";
                txtCredits.Text = row.Cells["Credits"].Value?.ToString() ?? "";

                txtCourseID.ReadOnly = true;
                txtCourseID.BackColor = Color.FromArgb(233, 236, 239); // Light gray to signify readonly
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void ResetForm()
        {
            isBinding = true;
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtCredits.Clear();

            txtCourseID.ReadOnly = false;
            txtCourseID.BackColor = Color.White;
            
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            if (dgvCourses.Rows.Count > 0)
                dgvCourses.ClearSelection();
            isBinding = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string creditsText = txtCredits.Text.Trim();
            if (!int.TryParse(creditsText, out int credits) || credits <= 0)
            {
                MessageBox.Show(
                    "Số tín chỉ phải là một số nguyên dương (> 0). Vui lòng nhập lại!",
                    "Lỗi Nhập Liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCredits.Focus();
                return;
            }

            string courseID = txtCourseID.Text.Trim();
            string courseName = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseID))
            {
                MessageBox.Show("Mã môn học không được để trống!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Tên môn học không được để trống!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return;
            }

            try
            {
                Course course = new Course
                {
                    CourseID = courseID,
                    CourseName = courseName,
                    Credits = credits
                };

                courseBLL.AddCourse(course);
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCourses();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string creditsText = txtCredits.Text.Trim();
            if (!int.TryParse(creditsText, out int credits) || credits <= 0)
            {
                MessageBox.Show(
                    "Số tín chỉ phải là một số nguyên dương (> 0). Vui lòng nhập lại!",
                    "Lỗi Nhập Liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCredits.Focus();
                return;
            }

            string courseID = txtCourseID.Text.Trim();
            string courseName = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Tên môn học không được để trống!", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return;
            }

            try
            {
                Course course = new Course
                {
                    CourseID = courseID,
                    CourseName = courseName,
                    Credits = credits
                };

                courseBLL.UpdateCourse(course);
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCourses();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string courseID = txtCourseID.Text.Trim();
            if (string.IsNullOrWhiteSpace(courseID)) return;

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa môn học '{courseID}' cùng với tất cả điểm liên quan không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    courseBLL.DeleteCourse(courseID);
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCourses();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
