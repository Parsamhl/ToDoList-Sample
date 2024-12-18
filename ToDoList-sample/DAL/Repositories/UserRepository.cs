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

        public void ChangePassword(string userName, string password, string newPassword)
        {
            var user = _appDbContext.users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if(user is null)
            {
                throw new Exception("User not Foun !");
            }else
            {
                user.Password = newPassword;
                _appDbContext.SaveChanges();
            }
        }

        public void GetTask(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserBy(string userName )

            => _appDbContext.users.FirstOrDefault(u => u.UserName == userName);

        public bool PasswordValidation(string userName, string password)
        
          => _appDbContext.users.Any(u => u.UserName == userName && u.Password == password);

        
    }
}
