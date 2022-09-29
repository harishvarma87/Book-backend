using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class AdminController : ApiController
    {
        private IAdminRepository repository;
        public AdminController()
        {
            repository = new AdminSqlImp();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllAdmins();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(Admin admin)
        {
            var data = repository.AddAdmin(admin);
            return Ok(data);
        }
    }
}
