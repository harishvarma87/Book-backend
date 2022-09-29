using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    internal interface ICartRepository
    {
        List<Cart> GetCart();
        Cart AddCart(Cart cart);
        void DeleteCart(int cartId);
        void UpdateCart(Cart cart);
  

    }
}
