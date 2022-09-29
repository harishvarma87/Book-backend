using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public int AddressId { get; set; }
        public string Date { get; set; }
        public Orders(int orderId, int userid, int bookid, int quantity, int addressid, string date)
        {
            OrderId = orderId;
            UserId = userid;
            BookId = bookid;
            Quantity = quantity;
            AddressId = addressid;
            Date = date;
        }
    }
}