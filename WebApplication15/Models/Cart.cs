using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public Cart(int cartid, int userid, int bookid, int quantity)
        {
            CartId = cartid;
            UserId = userid;
            BookId = bookid;
            Quantity = quantity;
        }
    }
}