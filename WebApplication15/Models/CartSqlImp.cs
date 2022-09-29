using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication15.Models
{
    public class CartSqlImp : ICartRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public CartSqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        public Cart AddCart(Cart cart)
        {
            comm.CommandText = "insert into Cart values (" + cart.UserId + ", " + cart.BookId + ", " + cart.Quantity + ")";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return cart;
            }
            else
            {
                return null;
            }
        }

        public void DeleteCart(int cartId)
        {
            comm.CommandText = "delete from Cart where CartId = " + cartId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        public List<Cart> GetCart()
        {
            List<Cart> list = new List<Cart>();
            comm.CommandText = "select * from Cart";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CartId"]);
                int userId = Convert.ToInt32(reader["UserId"]);
                int bookId = Convert.ToInt32(reader["BookId"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);
                list.Add(new Cart(id, userId, bookId, quantity));
            }
            conn.Close();
            return list;
        }

        public void UpdateCart(Cart cart)
        {
            comm.CommandText = "update Cart set UserId = " + cart.UserId + ", BookId = " + cart.BookId +
                ", Quantity = " + cart.Quantity + " where CartId = " + cart.CartId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}