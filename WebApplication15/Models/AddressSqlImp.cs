using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication15.Models
{
    public class AddressSqlImp : IAddressRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public AddressSqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public Address AddAddress(Address address)
        {
            comm.CommandText = "insert into Address values (" + address.UserId + ", '" + address.HouseNo + "', '" + address.Street +
                "', '" + address.City + "', '" + address.State + "', " + address.Pincode + ")";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return address;
            }
            else
            {
                return null;
            }
        }

        public List<Address> GetAllAddresses()
        {
            List<Address> list = new List<Address>();
            comm.CommandText = "select * from Address";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int addressId = Convert.ToInt32(reader["AddressId"]);
                int userId = Convert.ToInt32(reader["UserId"]);
                string houseNo = reader["HouseNo"].ToString();
                string street = reader["Street"].ToString();
                string city = reader["City"].ToString();
                string state = reader["State"].ToString();
                int pincode = Convert.ToInt32(reader["Pincode"]);
                list.Add(new Address(addressId, userId, houseNo, street, city, state, pincode));
            }
            conn.Close();
            return list;
        }

        public List<Address> GetAddressByUser(int userid)
        {
            List<Address> list = new List<Address>();
            comm.CommandText = "select * from Address where UserId = " + userid;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int addressId = Convert.ToInt32(reader["AddressId"]);
                string houseNo = reader["HouseNo"].ToString();
                string street = reader["Street"].ToString();
                string city = reader["City"].ToString();
                string state = reader["State"].ToString();
                int pincode = Convert.ToInt32(reader["Pincode"]);
                list.Add(new Address(addressId, userid, houseNo, street, city, state, pincode));
            }
            conn.Close();
            return list;
        }

        public void DeleteAddress(int addressid)
        {
            comm.CommandText = "delete from Address where AddressId = " + addressid;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        
        

        public void UpdateAddress(Address address)
        {
            comm.CommandText = "update Address set UserId = " + address.UserId + ", HouseNo = '" + address.HouseNo +
                "', Street = '" + address.Street + "', City = '" + address.City + "', State = '" + address.State +
                "', Pincode = " + address.Pincode + " where AddressId = " + address.AddressId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}