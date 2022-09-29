using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication15.Models
{
    public class UserSqlImp : IUserRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public UserSqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public User AddUser(User user)
        {
            comm.CommandText = "insert into Users values (" + user.Password + ")";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            comm.CommandText = "select * from [User]";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int userid = Convert.ToInt32(reader["username"]);
                string password = reader["Password"].ToString();

                list.Add(new User(userid, password));
            }
            conn.Close();
            return list;
        }

    }
}