using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository repository;
        public UserController()
        {
            repository = new UserSqlImp();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllUsers();
            return Ok(data);
        }
        [HttpPost]
        public IHttpActionResult Post(User user)
        {
            var data = repository.AddUser(user);
            return Ok(data);
        }
    }
}
