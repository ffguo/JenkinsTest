using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leon.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "ffg"
            },
            new User
            {
                Id = 2,
                Name = "疯疯过"
            }
        };

        public User GetUser(int id)
        {
            return users.FirstOrDefault(a => a.Id == id);
        }
    }
}
