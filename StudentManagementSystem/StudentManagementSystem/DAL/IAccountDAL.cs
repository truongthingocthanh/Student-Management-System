using System.Collections.Generic;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public interface IAccountDAL
    {
        List<Account> GetAll();
        bool Add(Account acc);
        bool Update(Account acc);
        bool Delete(string username);
        string GetError();
    }
}