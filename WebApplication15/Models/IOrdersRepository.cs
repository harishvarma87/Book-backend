using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    internal interface IOrdersRepository
    {
        List<Orders> GetOrder();
        void AddOrder(Orders order);
        void DeleteOrder(int orderId);
        void UpdateOrder(Orders order);
        Orders GetOrderById(int id);
    }
}
