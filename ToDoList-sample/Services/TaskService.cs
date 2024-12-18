using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Contracts.Services;
using ToDoList_sample.DAL.Repositories;
using ToDoList_sample.Entities;

namespace ToDoList_sample.Services
{
    public class TaskService : ITaskService
    {

        private readonly TaskRepository _taskRepository;

        public TaskService()
        {
            _taskRepository = new TaskRepository();
        }
        public void ChangeTaskStatus(int id)
        {
            var task = _taskRepository.GetTaskBy(id);
            if(task is null)
            {
                throw new Exception("task not found");
            }else
            {
                _taskRepository.ChangeTaskStatus(id);
            }
        }

        public List<Duty> GetAll()
         => _taskRepository.GetAll();
    }
}
