#nullable disable
using System.Collections.Generic;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.DAL;

public interface ICoVanHocTapDAL
{
    List<CoVanHocTap> GetAll();
    bool Add(CoVanHocTap cv);
    bool Update(CoVanHocTap cv);
    bool Delete(int id);
    bool Exists(string maCoVan);
}
