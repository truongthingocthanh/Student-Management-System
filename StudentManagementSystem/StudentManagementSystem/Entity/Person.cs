using System;

namespace StudentManagementSystem.Entity
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; } 
    }
}