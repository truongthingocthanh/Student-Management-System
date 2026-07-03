using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FacultyControl : UserControl
    {
        private bool isAdding = false;
        private bool isEditing = false;

        public FacultyControl()
        {
            InitializeComponent();

            EnableInput(false);
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
        private void dgvFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FacultyControl_Load(object sender, EventArgs e)
        {

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

            if (isAdding)
            {
                MessageBox.Show("Add successful! (Demo)");
            }
            else if (isEditing)
            {
                MessageBox.Show("Update successful! (Demo)");
            }

            ClearInput();
            EnableInput(false);

            isAdding = false;
            isEditing = false;
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
                MessageBox.Show("Delete successful! (Demo)");

                ClearInput();
            }
        }
    }
}
