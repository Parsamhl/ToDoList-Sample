using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Contracts.Repository;
using ToDoList_sample.Entities;

namespace ToDoList_sample.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public List<Duty> GetAllUserTasks()
        {
            throw new NotImplementedException();
        }

        public void GetTask(Duty d)
        {
           
        }

        public User GetUserBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
