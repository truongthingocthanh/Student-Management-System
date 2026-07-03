using System;

namespace StudentManagementSystem.Exceptions
{
    public class DiemKhongHopLeException : InvalidGradeException
    {
        public DiemKhongHopLeException() : base("Điểm không hợp lệ!") { }

        public DiemKhongHopLeException(string message) : base(message) { }

        public DiemKhongHopLeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
