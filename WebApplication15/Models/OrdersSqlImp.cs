using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication15.Models
{
    public class OrdersSqlImp:IOrdersRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public OrdersSqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public void AddOrder(Orders order)
        {
            comm.CommandText = "insert into Orders values (" + order.UserId + ", " + order.BookId + ", " + order.Quantity + ", "
               + order.AddressId + ", '" + order.Date + "')";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        public List<Orders> GetOrder()
        {
            List<Orders> list = new List<Orders>();
            comm.CommandText = "select * from Orders";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["OrderId"]);
                int userId = Convert.ToInt32(reader["UserId"]);
                int bookId = Convert.ToInt32(reader["BookId"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);
                int addressId = Convert.ToInt32(reader["AddressId"]);
                string date = reader["Date"].ToString();
                list.Add(new Orders(id, userId, bookId, quantity, addressId, date));
            }
            conn.Close();
            return list;
        }
        public Orders GetOrderById(int id)
        {
            comm.CommandText = "select * from Orders where OrderId=" + id;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int orderid = Convert.ToInt32(reader["OrderId"]);
                int userId = Convert.ToInt32(reader["UserId"]);
                int bookId = Convert.ToInt32(reader["BookId"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);
                int addressId = Convert.ToInt32(reader["AddressId"]);
                string date = reader["Date"].ToString();
                Orders cat = new Orders(orderid, userId, bookId, quantity, addressId, date);
                return cat;

            }
            conn.Close();
            return null;
        }


        public void DeleteOrder(int orderId)
        {
            comm.CommandText = "delete from Orders where OrderId = " + orderId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        
        public Orders GetOrderById(int id)
        {
            comm.CommandText = "select * from Orders where OrderId=" + id;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int orderid = Convert.ToInt32(reader["OrderId"]);
                int userId = Convert.ToInt32(reader["UserId"]);
                int bookId = Convert.ToInt32(reader["BookId"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);
                int addressId = Convert.ToInt32(reader["AddressId"]);
                string date = reader["Date"].ToString();
                Orders cat = new Orders(orderid, userId, bookId, quantity, addressId, date);
                return cat;

            }
            conn.Close();
            return null;
        }

        public void UpdateOrder(Orders order)
        {
            comm.CommandText = "update Orders set UserId = " + order.UserId + ", BookId = " + order.BookId +
                ", Quantity = " + order.Quantity + " where OrderId = " + order.OrderId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}