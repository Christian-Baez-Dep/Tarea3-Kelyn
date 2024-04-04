using Data.Context;
using Data.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class RepositoryUser : IRepositoryUser
    {
        private readonly ApplicationContext _context;

        public RepositoryUser(ApplicationContext context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                User user = _context.Users.Find(id);
                if (user == null)
                {
                    return false;
                }
                else
                {


                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public User Get(int id)
        {
            try
            {
                return _context.Users.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public User GetUserByEmailPassword(string email, string password)
        {
            try
            {
                return _context.Users.Where(c => c.Email == email & c.Password == password).AsEnumerable().Single();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                User userCambiar = _context.Users.Find(entity.Id);
                userCambiar.Email = entity.Email;
                userCambiar.Password = entity.Password;
                _context.Update(userCambiar);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public User CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                return  _context.Users.FirstOrDefault(c => c.Email == email);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

