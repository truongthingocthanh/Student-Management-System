using System.Collections.Generic;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public interface IStudentDAL
    {
        List<Student> GetAll();
        bool Add(Student student);
        bool Update(Student student);
        bool Delete(string studentID);
        string GetError();
    }
}