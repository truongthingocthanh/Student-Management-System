#nullable disable
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyGiaoDuc.DAL;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.Presentation;

public partial class FormQuanLyCoVan : Form
{
    private readonly ICoVanHocTapDAL _coVanDAL = new CoVanHocTapDAL();
    private readonly ILopDAL _lopDAL = new LopDAL();
    private BindingSource _bindingSource = new BindingSource();

    public FormQuanLyCoVan()
    {
        InitializeComponent();
        CommonHelper.SetCustomIcon(this);

        // Cấu hình Design
        CommonHelper.ConfigureFlatButton(btnThem, Color.FromArgb(79, 70, 229));
        CommonHelper.ConfigureFlatButton(btnSua, Color.FromArgb(16, 185, 129));
        CommonHelper.ConfigureFlatButton(btnXoa, Color.FromArgb(239, 68, 68));
        CommonHelper.ConfigureFlatButton(btnLamMoi, Color.FromArgb(107, 114, 128));
        CommonHelper.ConfigureDataGridView(dgvCoVan);

        // Events
        btnThem.Click += BtnThem_Click;
        btnSua.Click += BtnSua_Click;
        btnXoa.Click += BtnXoa_Click;
        btnLamMoi.Click += BtnLamMoi_Click;
        dgvCoVan.SelectionChanged += DgvCoVan_SelectionChanged;
        cboMaLop.SelectedIndexChanged += CboMaLop_SelectedIndexChanged;

        ConfigureDataGridViewColumns();
        LoadDepartments();
        LoadClasses();
        LoadData();
    }

    private void ConfigureDataGridViewColumns()
    {
        dgvCoVan.AutoGenerateColumns = false;

        var colId = new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 };
        var colMa = new DataGridViewTextBoxColumn { DataPropertyName = "MaCoVan", HeaderText = "ADVISOR CODE", Width = 110 };
        var colTen = new DataGridViewTextBoxColumn { DataPropertyName = "TenCoVan", HeaderText = "ADVISOR NAME", Width = 180, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
        
        var colNgaySinh = new DataGridViewTextBoxColumn { DataPropertyName = "NgaySinh", HeaderText = "DATE OF BIRTH", Width = 110 };
        colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";

        var colGioiTinh = new DataGridViewTextBoxColumn { DataPropertyName = "GioiTinh", HeaderText = "GENDER", Width = 80 };
        var colMaLop = new DataGridViewTextBoxColumn { DataPropertyName = "MaLop", HeaderText = "CLASS CODE", Width = 110 };
        var colMaKhoa = new DataGridViewTextBoxColumn { DataPropertyName = "MaKhoa", HeaderText = "DEPT CODE", Width = 110 };

        dgvCoVan.Columns.Clear();
        dgvCoVan.Columns.AddRange(colId, colMa, colTen, colNgaySinh, colGioiTinh, colMaLop, colMaKhoa);
    }

    private void LoadDepartments()
    {
        cboMaKhoa.Items.Clear();
        cboMaKhoa.Items.AddRange(new object[] { "FIT", "FBA", "FEE", "FME" });
        if (cboMaKhoa.Items.Count > 0) cboMaKhoa.SelectedIndex = 0;
    }

    private void LoadClasses()
    {
        try
        {
            cboMaLop.Items.Clear();
            var classes = _lopDAL.GetAll();
            foreach (var lop in classes)
            {
                cboMaLop.Items.Add(lop.MaLop);
            }
            if (cboMaLop.Items.Count > 0) cboMaLop.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading classes: {ex.Message}");
        }
    }

    private void LoadData()
    {
        try
        {
            _bindingSource.DataSource = _coVanDAL.GetAll();
            dgvCoVan.DataSource = _bindingSource;
            ResetFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Load Data Error: {ex.Message}");
        }
    }

    private void CboMaLop_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboMaLop.SelectedItem != null)
        {
            string maLop = cboMaLop.SelectedItem.ToString();
            var lop = _lopDAL.GetAll().FirstOrDefault(l => l.MaLop == maLop);
            if (lop != null)
            {
                cboMaKhoa.SelectedItem = lop.MaKhoa;
            }
        }
    }

    private void DgvCoVan_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvCoVan.SelectedRows.Count > 0)
        {
            var cv = (CoVanHocTap)dgvCoVan.SelectedRows[0].DataBoundItem;
            txtId.Text = cv.Id.ToString();
            txtMaCoVan.Text = cv.MaCoVan;
            txtTenCoVan.Text = cv.TenCoVan;
            dtpNgaySinh.Value = cv.NgaySinh;
            if (cv.GioiTinh == "Male") radNam.Checked = true;
            else radNu.Checked = true;
            
            cboMaLop.SelectedItem = cv.MaLop;
            cboMaKhoa.SelectedItem = cv.MaKhoa;
        }
    }

    private void BtnThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaCoVan.Text) || string.IsNullOrWhiteSpace(txtTenCoVan.Text))
        {
            MessageBox.Show("Please enter both Advisor Code and Advisor Name!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string maCoVan = txtMaCoVan.Text.Trim();
        if (_coVanDAL.Exists(maCoVan))
        {
            MessageBox.Show("This Advisor Code already exists in the database!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (cboMaLop.SelectedItem == null)
        {
            MessageBox.Show("Please select a Class Code first!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var cv = new CoVanHocTap
        {
            MaCoVan = maCoVan,
            TenCoVan = txtTenCoVan.Text.Trim(),
            NgaySinh = dtpNgaySinh.Value,
            GioiTinh = radNam.Checked ? "Male" : "Female",
            MaLop = cboMaLop.SelectedItem.ToString(),
            MaKhoa = cboMaKhoa.SelectedItem?.ToString() ?? "FIT"
        };

        if (_coVanDAL.Add(cv))
        {
            MessageBox.Show("Academic Advisor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }

    private void BtnSua_Click(object sender, EventArgs e)
    {
        if (dgvCoVan.SelectedRows.Count == 0) return;

        if (string.IsNullOrWhiteSpace(txtMaCoVan.Text) || string.IsNullOrWhiteSpace(txtTenCoVan.Text))
        {
            MessageBox.Show("Please enter both Advisor Code and Advisor Name!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedCv = (CoVanHocTap)dgvCoVan.SelectedRows[0].DataBoundItem;
        string newMaCoVan = txtMaCoVan.Text.Trim();

        if (newMaCoVan.Equals(selectedCv.MaCoVan, StringComparison.OrdinalIgnoreCase) == false && _coVanDAL.Exists(newMaCoVan))
        {
            MessageBox.Show("This Advisor Code is already in use by another advisor!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        selectedCv.MaCoVan = newMaCoVan;
        selectedCv.TenCoVan = txtTenCoVan.Text.Trim();
        selectedCv.NgaySinh = dtpNgaySinh.Value;
        selectedCv.GioiTinh = radNam.Checked ? "Male" : "Female";
        selectedCv.MaLop = cboMaLop.SelectedItem?.ToString() ?? "";
        selectedCv.MaKhoa = cboMaKhoa.SelectedItem?.ToString() ?? "FIT";

        if (_coVanDAL.Update(selectedCv))
        {
            MessageBox.Show("Advisor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }

    private void BtnXoa_Click(object sender, EventArgs e)
    {
        if (dgvCoVan.SelectedRows.Count == 0) return;

        var selectedCv = (CoVanHocTap)dgvCoVan.SelectedRows[0].DataBoundItem;
        var result = MessageBox.Show($"Are you sure you want to delete advisor: {selectedCv.TenCoVan} ({selectedCv.MaCoVan})?", 
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            if (_coVanDAL.Delete(selectedCv.Id))
            {
                MessageBox.Show("Advisor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        txtMaCoVan.Text = string.Empty;
        txtTenCoVan.Text = string.Empty;
        dtpNgaySinh.Value = new DateTime(1990, 1, 1);
        radNam.Checked = true;
        
        LoadClasses();
        if (cboMaKhoa.Items.Count > 0) cboMaKhoa.SelectedIndex = 0;
        dgvCoVan.ClearSelection();
    }

    private void PanelInputCard_Paint(object sender, PaintEventArgs e)
    {
        using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
        {
            e.Graphics.DrawRectangle(pen, 0, 0, panelInputCard.Width - 1, panelInputCard.Height - 1);
        }
    }
}
