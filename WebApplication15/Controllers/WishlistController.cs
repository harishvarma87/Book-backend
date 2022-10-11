using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication16.Models;
namespace WebApplication16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private IWishrepository cartRepository;
        public WishlistController(IWishrepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }



        [HttpGet]
        public IActionResult Get()
        {
            var data = cartRepository.GetAllWishlist;
            return Ok(data);
        }



        [HttpPost]
        public IActionResult Post([FromBody] Wishlist cart)
        {
            var data = cartRepository.AddWishlist(cart);
            return Ok(cart);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = cartRepository.GetWishlistById(id);
            if (data == null)
                return NotFound("nothing is there Try again");
            return Ok(data);
        }

    }
}
