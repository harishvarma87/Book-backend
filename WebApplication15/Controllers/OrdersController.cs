using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class OrdersController : ApiController
    {
        private IOrdersRepository repository;

        public OrdersController()
        {
            repository = new OrdersSqlImp();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetOrder();
            return Ok(data);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var data = repository.GetOrderById(id);
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Add(Orders order)
        {
            repository.AddOrder(order);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.DeleteOrder(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(Orders order)
        {
            repository.UpdateOrder(order);
            return Ok();
        }
    }
}
