using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Admin
    {
        public int Userid { get; set; }
        public string Password { get; set; }

        public Admin(int username, string password)
        {
            Userid = username;
            Password = password;
        }
    }
}