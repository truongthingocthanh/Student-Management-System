#nullable disable
using System.Collections.Generic;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.DAL;

public interface ILopDAL
{
    List<Lop> GetAll();
    bool Add(Lop lop);
    bool Update(Lop lop);
    bool Delete(int id);
    bool Exists(string maLop);
}
