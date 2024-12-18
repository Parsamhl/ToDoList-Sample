using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Entities;
using ToDoList_sample.FrameWork;

namespace ToDoList_sample.Contracts.Services
{
    public interface IUserService
    {
        Result PasswordValidation(string userName, string password);
        List<Duty> TaskList(string userName);
        void ChangePassword(string userName , string password , string newPassword);



    }
}
