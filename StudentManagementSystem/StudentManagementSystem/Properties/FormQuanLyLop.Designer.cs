#nullable disable
namespace QuanLyGiaoDuc.Presentation
{
    partial class FormQuanLyLop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelInputCard = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.panelInputCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInputCard
            // 
            this.panelInputCard.BackColor = System.Drawing.Color.White;
            this.panelInputCard.Controls.Add(this.lblId);
            this.panelInputCard.Controls.Add(this.txtId);
            this.panelInputCard.Controls.Add(this.lblMaLop);
            this.panelInputCard.Controls.Add(this.txtMaLop);
            this.panelInputCard.Controls.Add(this.lblTenLop);
            this.panelInputCard.Controls.Add(this.txtTenLop);
            this.panelInputCard.Controls.Add(this.lblSoLuong);
            this.panelInputCard.Controls.Add(this.nudSoLuong);
            this.panelInputCard.Controls.Add(this.lblMaKhoa);
            this.panelInputCard.Controls.Add(this.cboMaKhoa);
            this.panelInputCard.Controls.Add(this.btnThem);
            this.panelInputCard.Controls.Add(this.btnSua);
            this.panelInputCard.Controls.Add(this.btnXoa);
            this.panelInputCard.Controls.Add(this.btnLamMoi);
            this.panelInputCard.Location = new System.Drawing.Point(20, 20);
            this.panelInputCard.Name = "panelInputCard";
            this.panelInputCard.Size = new System.Drawing.Size(760, 130);
            this.panelInputCard.TabIndex = 0;
            this.panelInputCard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInputCard_Paint);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblId.Location = new System.Drawing.Point(15, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(45, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 25);
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMaLop.Location = new System.Drawing.Point(120, 23);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(76, 17);
            this.lblMaLop.Text = "Class Code:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLop.Location = new System.Drawing.Point(198, 20);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(95, 25);
            this.txtMaLop.TabIndex = 2;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblTenLop.Location = new System.Drawing.Point(310, 23);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(80, 17);
            this.lblTenLop.Text = "Class Name:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLop.Location = new System.Drawing.Point(395, 20);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(160, 25);
            this.txtTenLop.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSoLuong.Location = new System.Drawing.Point(570, 23);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(42, 17);
            this.lblSoLuong.Text = "Count:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuong.Location = new System.Drawing.Point(618, 20);
            this.nudSoLuong.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 25);
            this.nudSoLuong.TabIndex = 4;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMaKhoa.Location = new System.Drawing.Point(15, 78);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(73, 17);
            this.lblMaKhoa.Text = "Dept Code:";
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaKhoa.Location = new System.Drawing.Point(92, 75);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(100, 25);
            this.cboMaKhoa.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(220, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(330, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Edit";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(440, 70);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(550, 70);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvLop
            // 
            this.dgvLop.Location = new System.Drawing.Point(20, 170);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(760, 300);
            this.dgvLop.TabIndex = 10;
            // 
            // FormQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.panelInputCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class Management";
            this.panelInputCard.ResumeLayout(false);
            this.panelInputCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputCard;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLop;
    }
}
