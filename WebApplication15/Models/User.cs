using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }

        public User(int userid, string password)
        {
            UserId = userid;
            Password = password;
        }
    }
}