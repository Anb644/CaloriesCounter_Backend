using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaloriesCounter.Modules.Authentications
{
    public class AuthenticationAppService:ApplicationService
    {
        private readonly List<User> _users;

        public AuthenticationAppService()
        {
            _users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Username = "admin",
                    Password = "12345" 
                }
            };
        }

        public string SignUp(string username, string password)
        {
            if (_users.Any(u => u.Username == username))
            {
                return "Username already exists.";
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = username,
                Password = password
            };

            _users.Add(user);

            return "User signed up successfully.";
        }

        public string Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return "Login successful.";
            }
            else
            {
                return "Invalid username or password.";
            }
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
