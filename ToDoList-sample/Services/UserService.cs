using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Contracts.Repository;
using ToDoList_sample.Contracts.Services;
using ToDoList_sample.DAL.Repositories;
using ToDoList_sample.Entities;
using ToDoList_sample.FrameWork;

namespace ToDoList_sample.Services
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;
        private readonly TaskRepository _taskRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
            _taskRepository = new TaskRepository();
        }
        public void ChangePassword(string userName, string password, string newPassword)
        {
            var user = _userRepository.GetUserBy(userName);
            if (password == user.Password)
            {
                user.Password = newPassword;
                _userRepository.ChangePassword(userName, password, newPassword);
            }
        }

        public Result PasswordValidation(string userName, string password)
        {
            var user = _userRepository.GetUserBy(userName);
            if (user.Password != password)
            {
                return new Result { Success = false, Message = "invalid user name or passwor!" };
            }
            else
            {
                return new Result { Success = true };
            }
        }
        public List<Duty> TaskList(string userName)

            => _taskRepository.GetUserTasks(userName);

    }
}
