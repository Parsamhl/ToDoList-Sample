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
        User GetUserBy(int id);
        void GetTask(Duty d);
        List<Duty> GetAllUserTasks();
        


    }
}
