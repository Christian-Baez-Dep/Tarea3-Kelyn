using Data.Context;
using Data.Interface;
using Entity;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        private readonly IRepositoryUser _repo;

        public UserService(IRepositoryUser repo)
        {
            _repo = repo;
        }



        public ResponseUser login(LoginDTO loginDTO)
        {
            var client = _repo.GetUserByEmailPassword(loginDTO.Email, loginDTO.Password);

            if (client != null)
            {
                return new ResponseUser(client.Id, client.Name);

            }
            else
            {
                return null;
            }
        }

        public ResponseUser RegistrarUsuario(RegistroRequest request)
        {
            var existingUser =  _repo.GetUserByEmail(request.Email);
            if (existingUser != null)
            {
                return null;
            }

            var newUser = new User
            {
                Email = request.Email,
                Password = request.Password,
                Name = request.Name
            };

            var createdUser = _repo.CreateUser(newUser);
            createdUser = _repo.GetUserByEmail(createdUser.Email);

            return new ResponseUser(createdUser.Id, createdUser.Name);
        }
    }
}
