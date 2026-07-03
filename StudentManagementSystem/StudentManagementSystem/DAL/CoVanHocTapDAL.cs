#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.DAL;

public class CoVanHocTapDAL : ICoVanHocTapDAL
{
    public List<CoVanHocTap> GetAll()
    {
        var list = new List<CoVanHocTap>();
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        SqliteDataReader reader = null;
        try
        {
            conn.Open();
            string query = "SELECT Id, MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaLop, MaKhoa FROM CoVanHocTap";
            cmd = new SqliteCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CoVanHocTap
                {
                    Id = reader.GetInt32(0),
                    MaCoVan = reader.GetString(1),
                    TenCoVan = reader.GetString(2),
                    NgaySinh = DateTime.Parse(reader.GetString(3)),
                    GioiTinh = reader.GetString(4),
                    MaLop = reader.GetString(5),
                    MaKhoa = reader.GetString(6)
                });
            }
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
        finally
        {
            if (reader != null) reader.Close();
            if (cmd != null) cmd.Dispose();
            if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
        }
        return list;
    }

    public bool Add(CoVanHocTap cv)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "INSERT INTO CoVanHocTap (MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaLop, MaKhoa) VALUES (@MaCoVan, @TenCoVan, @NgaySinh, @GioiTinh, @MaLop, @MaKhoa)";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaCoVan", cv.MaCoVan);
            cmd.Parameters.AddWithValue("@TenCoVan", cv.TenCoVan);
            cmd.Parameters.AddWithValue("@NgaySinh", cv.NgaySinh.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@GioiTinh", cv.GioiTinh);
            cmd.Parameters.AddWithValue("@MaLop", cv.MaLop);
            cmd.Parameters.AddWithValue("@MaKhoa", cv.MaKhoa);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            ShowError(ex);
            return false;
        }
        finally
        {
            if (cmd != null) cmd.Dispose();
            if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
        }
    }

    public bool Update(CoVanHocTap cv)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "UPDATE CoVanHocTap SET MaCoVan = @MaCoVan, TenCoVan = @TenCoVan, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, MaLop = @MaLop, MaKhoa = @MaKhoa WHERE Id = @Id";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", cv.Id);
            cmd.Parameters.AddWithValue("@MaCoVan", cv.MaCoVan);
            cmd.Parameters.AddWithValue("@TenCoVan", cv.TenCoVan);
            cmd.Parameters.AddWithValue("@NgaySinh", cv.NgaySinh.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@GioiTinh", cv.GioiTinh);
            cmd.Parameters.AddWithValue("@MaLop", cv.MaLop);
            cmd.Parameters.AddWithValue("@MaKhoa", cv.MaKhoa);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            ShowError(ex);
            return false;
        }
        finally
        {
            if (cmd != null) cmd.Dispose();
            if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
        }
    }

    public bool Delete(int id)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "DELETE FROM CoVanHocTap WHERE Id = @Id";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            ShowError(ex);
            return false;
        }
        finally
        {
            if (cmd != null) cmd.Dispose();
            if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
        }
    }

    public bool Exists(string maCoVan)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM CoVanHocTap WHERE MaCoVan = @MaCoVan";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaCoVan", maCoVan);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
        catch (Exception ex)
        {
            ShowError(ex);
            return false;
        }
        finally
        {
            if (cmd != null) cmd.Dispose();
            if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
        }
    }

    private void ShowError(Exception ex)
    {
        System.Windows.Forms.MessageBox.Show($"Advisor SQLite Operation Error: {ex.Message}");
    }
}
