using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication15.Models
{
    public class AdminSqlImp : IAdminRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public AdminSqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public Admin AddAdmin(Admin admin)
        {
            comm.CommandText = "insert into Admin values (" + admin.Password + ")";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }

        public List<Admin> GetAllAdmins()
        {
            List<Admin> list = new List<Admin>();
            comm.CommandText = "select * from Admin";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int userid = Convert.ToInt32(reader["id"]);
                string password = reader["Password"].ToString();
          
                list.Add(new Admin(userid, password));
            }
            conn.Close();
            return list;
        }
    }
}