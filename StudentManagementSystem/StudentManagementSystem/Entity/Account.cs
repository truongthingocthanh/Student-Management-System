using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.Entity
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Vai trò: Admin hoặc GiangVien
    }
}