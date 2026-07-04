using System;

namespace StudentManagementSystem.Entity
{
    public class Student : Person
    {
        public DateTime DateOfBirth { get; set; }
        public string ClassID { get; set; }
        public string ImagePath { get; set; } 

        public override string ToString()
        {
            return $"[{ID}] {FullName} - Class: {ClassID}";
        }
    }
}
