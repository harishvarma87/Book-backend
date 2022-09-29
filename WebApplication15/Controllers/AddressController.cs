using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class AddressController : ApiController
    {
        private IAddressRepository repository;

        public AddressController()
        {
            repository = new AddressSqlImp();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllAddresses();
            return Ok(data);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var data = repository.GetAddressByUser(id);
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Add(Address address)
        {
            repository.AddAddress(address);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(Address address)
        {
            repository.UpdateAddress(address);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.DeleteAddress(id);
            return Ok();
        }
    }
}
