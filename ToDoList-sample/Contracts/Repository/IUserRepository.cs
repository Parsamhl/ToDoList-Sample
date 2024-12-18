using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Entities;

namespace ToDoList_sample.Contracts.Repository
{
    public interface IUserRepository
    {
        User GetUserBy(string userName);
        bool PasswordValidation(string userName, string password);
        void GetTask(int id);
        void ChangePassword(string userName, string password, string newPassword);




    }
}
