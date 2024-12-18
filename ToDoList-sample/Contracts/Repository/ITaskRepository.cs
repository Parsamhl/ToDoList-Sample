using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Entities;

namespace ToDoList_sample.Contracts.Repository
{
    public interface ITaskRepository
    {
        void Add(Duty task);
        List<Duty> GetAll();
        void Delete(Duty task);
        void ChangeTaskStatus(int id);
        List<Duty> GetUserTasks(string userName);

        Duty GetTaskBy(int id);




    }
}
