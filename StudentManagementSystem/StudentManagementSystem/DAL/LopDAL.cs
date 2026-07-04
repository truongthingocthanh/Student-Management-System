#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyGiaoDuc.Entity;

namespace QuanLyGiaoDuc.DAL;

public class LopDAL : ILopDAL
{
    public List<Lop> GetAll()
    {
        var list = new List<Lop>();
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        SqliteDataReader reader = null;
        try
        {
            conn.Open();
            string query = "SELECT Id, MaLop, TenLop, SoLuong, MaKhoa FROM Lop";
            cmd = new SqliteCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Lop
                {
                    Id = reader.GetInt32(0),
                    MaLop = reader.GetString(1),
                    TenLop = reader.GetString(2),
                    SoLuong = reader.GetInt32(3),
                    MaKhoa = reader.GetString(4)
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

    public bool Add(Lop lop)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "INSERT INTO Lop (MaLop, TenLop, SoLuong, MaKhoa) VALUES (@MaLop, @TenLop, @SoLuong, @MaKhoa)";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
            cmd.Parameters.AddWithValue("@SoLuong", lop.SoLuong);
            cmd.Parameters.AddWithValue("@MaKhoa", lop.MaKhoa);
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

    public bool Update(Lop lop)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "UPDATE Lop SET MaLop = @MaLop, TenLop = @TenLop, SoLuong = @SoLuong, MaKhoa = @MaKhoa WHERE Id = @Id";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", lop.Id);
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
            cmd.Parameters.AddWithValue("@SoLuong", lop.SoLuong);
            cmd.Parameters.AddWithValue("@MaKhoa", lop.MaKhoa);
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
            string query = "DELETE FROM Lop WHERE Id = @Id";
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

    public bool Exists(string maLop)
    {
        SqliteConnection conn = DatabaseHelper.GetConnection();
        SqliteCommand cmd = null;
        try
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
            cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
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
        System.Windows.Forms.MessageBox.Show($"Class SQLite Operation Error: {ex.Message}");
    }
}
