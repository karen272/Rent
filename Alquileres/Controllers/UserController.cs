using Alquileres.Models;
using Alquileres.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public void AddUser(string name)
        {
            if (string.IsNullOrEmpty(name) )
                throw new ArgumentException("Name cannot be empty.");

            User newUser = new User { Name = name };
            _userService.AddUser(newUser);
        }

        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
    }
}
