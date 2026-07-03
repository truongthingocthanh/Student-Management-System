using System;

namespace StudentManagementSystem.Exceptions
{
    public class InvalidGradeException : Exception
    {
        public InvalidGradeException() : base("Invalid score!") { }

        public InvalidGradeException(string message) : base(message) { }

        public InvalidGradeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
