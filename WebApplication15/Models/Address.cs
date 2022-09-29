using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        public Address(int addressid, int userid, string houseno, string street,
            string city, string state, int pincode)
        {
            AddressId = addressid;
            UserId = userid;
            HouseNo = houseno;
            Street = street;
            City = city;
            State = state;
            Pincode = pincode;
        }
    }
}