using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository (DataContext context)
        {
            _context = context;
        }

        public void AddUser(UserTable user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public UserTable GetByEmailAndPassword(string email, string password)
        {
            UserTable u = _context.UserTables.FirstOrDefault(x => x.Email == email && x.Password == password);
            return u;
        }
    }
}
