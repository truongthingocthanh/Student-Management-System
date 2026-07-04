using System;
using System.Collections.Generic;
using System.Data.SQLite;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public class AccountDALSQLite : IAccountDAL
    {
        private const string CONN = "Data Source=data.sqlite;Version=3;";
        private SQLiteConnection con;
        private string error = "";

        public AccountDALSQLite()
        {
            con = new SQLiteConnection(CONN);
        }

        public string GetError() => error;

        // 1. Lấy toàn bộ danh sách tài khoản
        public List<Account> GetAll()
        {
            var list = new List<Account>();
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Account", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Account
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        // 2. Thêm tài khoản mới
        public bool Add(Account acc)
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Account (Username, Password, Role) VALUES (@u, @p, @r)", con);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password); 
                cmd.Parameters.AddWithValue("@r", acc.Role);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // 3. Cập nhật tài khoản (Xử lý thông minh: Nếu pass rỗng thì chỉ cập nhật Role)
        public bool Update(Account acc)
        {
            try
            {
                con.Open();
                string query = string.IsNullOrEmpty(acc.Password)
                    ? "UPDATE Account SET Role = @r WHERE Username = @u"
                    : "UPDATE Account SET Password = @p, Role = @r WHERE Username = @u";

                var cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@r", acc.Role);

                if (!string.IsNullOrEmpty(acc.Password))
                {
                    cmd.Parameters.AddWithValue("@p", acc.Password);
                }

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // 4. Xóa tài khoản
        public bool Delete(string username)
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("DELETE FROM Account WHERE Username = @u", con);
                cmd.Parameters.AddWithValue("@u", username);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}