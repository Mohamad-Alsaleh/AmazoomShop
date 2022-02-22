using AmazoomShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazoomShop.Server.Services.ProductService
{
    public interface iProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategorys(string categoryUrl);
        Task<Product> GetProduct(int id);
    }
}
