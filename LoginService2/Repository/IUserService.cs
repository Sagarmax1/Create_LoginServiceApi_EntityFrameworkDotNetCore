using LoginService2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService2.Repository
{
    public interface IUserService
    {
        int CreateUser(User user);
        bool LoginValidate(string username, string password);
    }
}
