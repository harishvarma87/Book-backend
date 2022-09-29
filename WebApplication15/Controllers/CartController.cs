using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class CartController : ApiController
    {
        private ICartRepository repository;

        public CartController()
        {
            repository = new CartSqlImp();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetCart();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Add(Cart cart)
        {
            repository.AddCart(cart);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.DeleteCart(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(Cart cart)
        {
            repository.UpdateCart(cart);
            return Ok();
        }

    }
}
