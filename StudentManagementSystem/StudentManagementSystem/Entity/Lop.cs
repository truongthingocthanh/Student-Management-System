#nullable disable
using QuanLyGiaoDuc;

namespace StudentManagementSystem.Entity;

public class Lop
{
    public int Id { get; set; }
    public string MaLop { get; set; }
    public string TenLop { get; set; }
    public int SoLuong { get; set; }
    public string MaKhoa { get; set; }
}
