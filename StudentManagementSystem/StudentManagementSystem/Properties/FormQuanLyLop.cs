#nullable disable
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyGiaoDuc.DAL;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.Presentation;

public partial class FormQuanLyLop : Form
{
    private readonly ILopDAL _lopDAL = new LopDAL();
    private BindingSource _bindingSource = new BindingSource();

    public FormQuanLyLop()
    {
        InitializeComponent();
        CommonHelper.SetCustomIcon(this);

        // Cấu hình Design
        CommonHelper.ConfigureFlatButton(btnThem, Color.FromArgb(79, 70, 229));
        CommonHelper.ConfigureFlatButton(btnSua, Color.FromArgb(16, 185, 129));
        CommonHelper.ConfigureFlatButton(btnXoa, Color.FromArgb(239, 68, 68));
        CommonHelper.ConfigureFlatButton(btnLamMoi, Color.FromArgb(107, 114, 128));
        CommonHelper.ConfigureDataGridView(dgvLop);

        // Events
        btnThem.Click += BtnThem_Click;
        btnSua.Click += BtnSua_Click;
        btnXoa.Click += BtnXoa_Click;
        btnLamMoi.Click += BtnLamMoi_Click;
        dgvLop.SelectionChanged += DgvLop_SelectionChanged;

        ConfigureDataGridViewColumns();
        LoadDepartments();
        LoadData();
    }

    private void ConfigureDataGridViewColumns()
    {
        dgvLop.AutoGenerateColumns = false;

        var colId = new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60 };
        var colMa = new DataGridViewTextBoxColumn { DataPropertyName = "MaLop", HeaderText = "CLASS CODE", Width = 150 };
        var colTen = new DataGridViewTextBoxColumn { DataPropertyName = "TenLop", HeaderText = "CLASS NAME", Width = 280, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
        var colSoLuong = new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "STUDENT COUNT", Width = 130 };
        var colMaKhoa = new DataGridViewTextBoxColumn { DataPropertyName = "MaKhoa", HeaderText = "DEPT CODE", Width = 120 };

        dgvLop.Columns.Clear();
        dgvLop.Columns.AddRange(colId, colMa, colTen, colSoLuong, colMaKhoa);
    }

    private void LoadDepartments()
    {
        cboMaKhoa.Items.Clear();
        cboMaKhoa.Items.AddRange(new object[] { "FIT", "FBA", "FEE", "FME" });
        if (cboMaKhoa.Items.Count > 0)
        {
            cboMaKhoa.SelectedIndex = 0;
        }
    }

    private void LoadData()
    {
        try
        {
            _bindingSource.DataSource = _lopDAL.GetAll();
            dgvLop.DataSource = _bindingSource;
            ResetFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Load Data Error: {ex.Message}");
        }
    }

    private void DgvLop_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvLop.SelectedRows.Count > 0)
        {
            var lop = (Lop)dgvLop.SelectedRows[0].DataBoundItem;
            txtId.Text = lop.Id.ToString();
            txtMaLop.Text = lop.MaLop;
            txtTenLop.Text = lop.TenLop;
            nudSoLuong.Value = lop.SoLuong;
            cboMaKhoa.SelectedItem = lop.MaKhoa;
        }
    }

    private void BtnThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
        {
            MessageBox.Show("Please enter both Class Code and Class Name!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string maLop = txtMaLop.Text.Trim();
        if (_lopDAL.Exists(maLop))
        {
            MessageBox.Show("This Class Code already exists in the database!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (cboMaKhoa.SelectedItem == null)
        {
            MessageBox.Show("Please select a Department Code!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var lop = new Lop
        {
            MaLop = maLop,
            TenLop = txtTenLop.Text.Trim(),
            SoLuong = (int)nudSoLuong.Value,
            MaKhoa = cboMaKhoa.SelectedItem.ToString()
        };

        if (_lopDAL.Add(lop))
        {
            MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }

    private void BtnSua_Click(object sender, EventArgs e)
    {
        if (dgvLop.SelectedRows.Count == 0) return;

        if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
        {
            MessageBox.Show("Please enter both Class Code and Class Name!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedLop = (Lop)dgvLop.SelectedRows[0].DataBoundItem;
        string newMaLop = txtMaLop.Text.Trim();

        if (newMaLop.Equals(selectedLop.MaLop, StringComparison.OrdinalIgnoreCase) == false && _lopDAL.Exists(newMaLop))
        {
            MessageBox.Show("This Class Code is already in use by another class!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        selectedLop.MaLop = newMaLop;
        selectedLop.TenLop = txtTenLop.Text.Trim();
        selectedLop.SoLuong = (int)nudSoLuong.Value;
        selectedLop.MaKhoa = cboMaKhoa.SelectedItem?.ToString() ?? "";

        if (_lopDAL.Update(selectedLop))
        {
            MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }

    private void BtnXoa_Click(object sender, EventArgs e)
    {
        if (dgvLop.SelectedRows.Count == 0) return;

        var selectedLop = (Lop)dgvLop.SelectedRows[0].DataBoundItem;
        var result = MessageBox.Show($"Are you sure you want to delete class: {selectedLop.TenLop} ({selectedLop.MaLop})?", 
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            if (_lopDAL.Delete(selectedLop.Id))
            {
                MessageBox.Show("Class deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }

    private void BtnLamMoi_Click(object sender, EventArgs e)
    {
        ResetFields();
    }

    private void ResetFields()
    {
        txtId.Text = string.Empty;
        txtMaLop.Text = string.Empty;
        txtTenLop.Text = string.Empty;
        nudSoLuong.Value = 0;
        if (cboMaKhoa.Items.Count > 0) cboMaKhoa.SelectedIndex = 0;
        dgvLop.ClearSelection();
    }

    private void PanelInputCard_Paint(object sender, PaintEventArgs e)
    {
        using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
        {
            e.Graphics.DrawRectangle(pen, 0, 0, panelInputCard.Width - 1, panelInputCard.Height - 1);
        }
    }
}
