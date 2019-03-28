using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IOrderRepository
    {
        //this is the same as for the IProductRepository
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
