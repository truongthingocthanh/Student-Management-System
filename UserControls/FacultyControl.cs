using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class FacultyControl : UserControl
    {
        private bool isAdding = false;
        private bool isEditing = false;
        private FacultyDAL facultyDAL = new FacultyDAL();

        public FacultyControl()
        {
            InitializeComponent();

            EnableInput(true);
        }
        private void ClearInput()
        {
            txtFacultyId.Clear();
            txtFacultyName.Clear();
        }
        private void EnableInput(bool enable)
        {
            txtFacultyId.Enabled = enable;
            txtFacultyName.Enabled = enable;

            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void LoadFaculty()
        {
            dgvFaculty.AutoGenerateColumns = false;
            dgvFaculty.DataSource = facultyDAL.GetAllFaculties();
        }
        private void dgvFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FacultyControl_Load(object sender, EventArgs e)
        {
            LoadFaculty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearInput();
            EnableInput(true);

            txtFacultyId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFacultyId.Text.Trim() == "")
            {
                MessageBox.Show("Faculty ID cannot be empty!");
                txtFacultyId.Focus();
                return;
            }

            if (txtFacultyName.Text.Trim() == "")
            {
                MessageBox.Show("Faculty Name cannot be empty!");
                txtFacultyName.Focus();
                return;
            }

            Faculty faculty = new Faculty();
            faculty.FacultyId = txtFacultyId.Text.Trim();
            faculty.FacultyName = txtFacultyName.Text.Trim();

            bool result = false;

            if (isAdding)
            {
                result = facultyDAL.AddFaculty(faculty);
            }
            else if (isEditing)
            {
                result = facultyDAL.UpdateFaculty(faculty);
            }

            if (result)
            {
                MessageBox.Show("Saved successfully.");

                LoadFaculty();
                ClearInput();
                EnableInput(false);

                isAdding = false;
                isEditing = false;
            }
            else
            {
                MessageBox.Show("Save failed.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInput();

            EnableInput(false);

            isAdding = false;
            isEditing = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();

            txtFacultyId.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFacultyId.Text.Trim() == "")
            {
                MessageBox.Show("Please select a faculty first!");
                return;
            }

            isEditing = true;
            isAdding = false;

            EnableInput(true);

            txtFacultyName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFacultyId.Text.Trim() == "")
            {
                MessageBox.Show("Please select a faculty first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this faculty?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (facultyDAL.DeleteFaculty(txtFacultyId.Text.Trim()))
                {
                    MessageBox.Show("Deleted successfully.");

                    LoadFaculty();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                LoadFaculty();
                return;
            }

            dgvFaculty.DataSource = facultyDAL.SearchFaculty(keyword);

            if (dgvFaculty.Rows.Count == 0)
            {
                MessageBox.Show("No faculty found!",
                                "Search",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvFaculty.Rows[e.RowIndex];

            txtFacultyId.Text = row.Cells["FacultyId"].Value.ToString();
            txtFacultyName.Text = row.Cells["FacultyName"].Value.ToString();
        }
    }
}
