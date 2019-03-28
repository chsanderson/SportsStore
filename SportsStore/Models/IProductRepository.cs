using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        //This Allows editing and creation of Products
        void SaveProduct(Product product);

        //this allows the deletion of products
        Product DeleteProduct(int productID);
    }
}
