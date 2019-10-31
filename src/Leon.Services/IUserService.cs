using System;
using System.Collections.Generic;
using System.Text;

namespace Leon.Services
{
    public interface IUserService
    {
        User GetUser(int id);
    }
}
