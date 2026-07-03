using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class LecturerControl : UserControl
    {
        public LecturerControl()
        {
            InitializeComponent();
        }
        private List<Lecturer> lecturerList = new List<Lecturer>();
        private void LoadData()
        {
            dgvLecturer.DataSource = null;
            dgvLecturer.DataSource = lecturerList;
        }

        private void lblLecturerID_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLecturerID.Text))
            {
                MessageBox.Show("Please enter Lecturer ID.");
                txtLecturerID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name.");
                txtFullName.Focus();
                return;
            }

            if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.");
                cboGender.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDegree.Text))
            {
                MessageBox.Show("Please enter Degree.");
                txtDegree.Focus();
                return;
            }

            if (cboFaculty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Faculty.");
                cboFaculty.Focus();
                return;
            }
            if (lecturerList.Any(x => x.LecturerID == txtLecturerID.Text))
            {
                MessageBox.Show("Lecturer ID already exists.");
                txtLecturerID.Focus();
                return;
            }
            Lecturer lecturer = new Lecturer();

            lecturer.LecturerID = txtLecturerID.Text;
            lecturer.FullName = txtFullName.Text;
            lecturer.Gender = cboGender.Text;
            lecturer.Degree = txtDegree.Text;
            lecturer.Faculty = cboFaculty.Text;

            lecturerList.Add(lecturer);

            LoadData();

            btnClear.PerformClick();

            MessageBox.Show("Added successfully.");
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

        private void dgvLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLecturer.CurrentRow == null)
            {
                MessageBox.Show("Please select a lecturer.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this lecturer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dgvLecturer.CurrentRow.Index;

            lecturerList.RemoveAt(index);

            LoadData();

            btnClear.PerformClick();

            MessageBox.Show("Deleted successfully.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLecturerID.Text))
            {
                MessageBox.Show("Please enter Lecturer ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name.");
                return;
            }

            if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDegree.Text))
            {
                MessageBox.Show("Please enter Degree.");
                return;
            }

            if (cboFaculty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Faculty.");
                return;
            }
            if (dgvLecturer.CurrentRow == null)
                return;

            int index = dgvLecturer.CurrentRow.Index;

            lecturerList[index].LecturerID = txtLecturerID.Text;
            lecturerList[index].FullName = txtFullName.Text;
            lecturerList[index].Gender = cboGender.Text;
            lecturerList[index].Degree = txtDegree.Text;
            lecturerList[index].Faculty = cboFaculty.Text;

            LoadData();

            MessageBox.Show("Updated successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (keyword == "")
            {
                LoadData();
                return;
            }

            var result = lecturerList.Where(x =>
                x.LecturerID.ToLower().Contains(keyword) ||
                x.FullName.ToLower().Contains(keyword) ||
                x.Faculty.ToLower().Contains(keyword))
                .ToList();

            dgvLecturer.DataSource = null;
            dgvLecturer.DataSource = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved successfully.");
        }

        private void dgvLecturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvLecturer.Rows[e.RowIndex];

            txtLecturerID.Text = row.Cells["LecturerID"].Value?.ToString();
            txtFullName.Text = row.Cells["FullName"].Value?.ToString();
            cboGender.Text = row.Cells["Gender"].Value?.ToString();
            txtDegree.Text = row.Cells["Degree"].Value?.ToString();
            cboFaculty.Text = row.Cells["Faculty"].Value?.ToString();
        }
    }
}
