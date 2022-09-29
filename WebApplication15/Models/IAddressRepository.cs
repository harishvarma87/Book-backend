using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    internal interface IAddressRepository
    {
        Address AddAddress(Address address);
        List<Address> GetAllAddresses();
        List<Address> GetAddressByUser(int userid);
        
        void DeleteAddress(int addressid);
        void UpdateAddress(Address address);

    }
}
