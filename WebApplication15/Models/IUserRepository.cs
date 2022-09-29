using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    internal interface IUserRepository
    {
        List<User> GetAllUsers();
        User AddUser(User user);
    }
}
