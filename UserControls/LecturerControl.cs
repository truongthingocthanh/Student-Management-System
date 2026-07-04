using System;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class LecturerControl : UserControl
    {
        private LecturerDAL lecturerDAL = new LecturerDAL();
        private FacultyDAL facultyDAL = new FacultyDAL();

        public LecturerControl()
        {
            InitializeComponent();

            LoadFaculty();   // Nạp danh sách khoa
            LoadData();      // Nạp danh sách giảng viên
        }

        private void LoadData()
        {
            dgvLecturer.AutoGenerateColumns = false;
            dgvLecturer.DataSource = lecturerDAL.GetAllLecturers();
        }

        private void LoadFaculty()
        {
            cboFaculty.DataSource = facultyDAL.GetAllFaculties();
            cboFaculty.DisplayMember = "FacultyName";
            cboFaculty.ValueMember = "FacultyId";
            cboFaculty.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLecturerID.Text.Trim() == "")
            {
                MessageBox.Show("Lecturer ID cannot be empty!");
                return;
            }

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Full Name cannot be empty!");
                return;
            }

            Lecturer lecturer = new Lecturer();

            lecturer.LecturerID = txtLecturerID.Text.Trim();
            lecturer.FullName = txtFullName.Text.Trim();
            lecturer.Gender = cboGender.Text;
            lecturer.Degree = txtDegree.Text.Trim();
            lecturer.Faculty = cboFaculty.SelectedValue.ToString();

            if (lecturerDAL.AddLecturer(lecturer))
            {
                MessageBox.Show("Added successfully.");

                LoadData();

                btnClear.PerformClick();
            }
            else
            {
                MessageBox.Show("Add failed.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();

            lecturer.LecturerID = txtLecturerID.Text.Trim();
            lecturer.FullName = txtFullName.Text.Trim();
            lecturer.Gender = cboGender.Text;
            lecturer.Degree = txtDegree.Text.Trim();
            lecturer.Faculty = cboFaculty.SelectedValue.ToString();

            if (lecturerDAL.UpdateLecturer(lecturer))
            {
                MessageBox.Show("Updated successfully.");

                LoadData();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtLecturerID.Text == "")
            {
                MessageBox.Show("Please select a lecturer.");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Delete this lecturer?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (lecturerDAL.DeleteLecturer(txtLecturerID.Text))
                {
                    MessageBox.Show("Deleted successfully.");

                    LoadData();

                    btnClear.PerformClick();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLecturer.AutoGenerateColumns = true;

            dgvLecturer.DataSource = lecturerDAL.SearchLecturer(txtSearch.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLecturerID.Clear();
            txtFullName.Clear();
            txtDegree.Clear();
            txtSearch.Clear();

            cboGender.SelectedIndex = -1;
            cboFaculty.SelectedIndex = -1;

            txtLecturerID.Focus();
        }

        private void dgvLecturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvLecturer.Rows[e.RowIndex];

            txtLecturerID.Text = row.Cells["LecturerID"].Value.ToString();
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            cboGender.Text = row.Cells["Gender"].Value.ToString();
            txtDegree.Text = row.Cells["Degree"].Value.ToString();
            cboFaculty.Text = row.Cells["Faculty"].Value.ToString();
        }

        private void lblLecturerID_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void dgvLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}