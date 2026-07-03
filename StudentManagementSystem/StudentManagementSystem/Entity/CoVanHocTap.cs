#nullable disable
using System;

namespace QuanLyGiaoDuc.Entity;

public class CoVanHocTap
{
    public int Id { get; set; }
    public string MaCoVan { get; set; }
    public string TenCoVan { get; set; }
    public DateTime NgaySinh { get; set; }
    public string GioiTinh { get; set; }
    public string MaLop { get; set; }
    public string MaKhoa { get; set; }
}
