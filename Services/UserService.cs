using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepository;

        public UserService(IUserRepository userrepository)
        {
            _userrepository = userrepository;
        }

        public void AddUser(UserTable user)
        {
           _userrepository.AddUser(user);
        }

        public UserTable GetByEmailAndPassword(string email, string password)
        {
          return _userrepository.GetByEmailAndPassword(email, password);
        }
    }
}
