using System;

namespace StudentManagementSystem.Entity
{
    public abstract class Person
    {
        public string ID { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
}