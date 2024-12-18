using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Contracts.Repository;
using ToDoList_sample.Entities;
using ToDoList_sample.Enums;

namespace ToDoList_sample.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly AppDbContext _appDbContext;

        public TaskRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public void Add(Duty task)
        {
            _appDbContext.tasks.Add(task);
            _appDbContext.SaveChanges();
        }

        public void ChangeTaskStatus(int id)
        {
            var task = _appDbContext.tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
            {
                throw new Exception("Task not found");

            }else
            {
                task.Status = StatusEnum.Done;
                _appDbContext.SaveChanges();
            }
   
        }

        public void Delete(Duty task)
        {
            _appDbContext.tasks.Remove(task);
            _appDbContext.SaveChanges();
        }

        public List<Duty> GetAll()
        {
            return _appDbContext.tasks.ToList();
        }

        public Duty GetTaskBy(int id)

            => _appDbContext.tasks.FirstOrDefault(x => x.Id == id);
            
        

        public List<Duty> GetUserTasks(string userName)
        {
            return _appDbContext.tasks
                .Where(x => x.User.UserName == userName)
                .Select(x => new Duty
                {
                    Title = x.Title,
                    Description = x.Description,
                    Status = x.Status,
                    TimeToDone = x.TimeToDone,
                }).ToList();
        }
    }
}
