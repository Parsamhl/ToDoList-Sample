using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Entities;

namespace ToDoList_sample.Contracts.Services
{
    public interface ITaskService
    {
        void ChangeTaskStatus(int id);
        List<Duty> GetAll(); 
    }
}
