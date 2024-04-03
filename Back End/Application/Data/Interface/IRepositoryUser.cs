using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IRepositoryUser : IRepository<User>
    {
        public User GetUserByEmailPassword(string email, string password);
        public User GetUserByEmail(string email);
        public User CreateUser(User user);
    }
}
