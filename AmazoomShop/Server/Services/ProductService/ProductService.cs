using AmazoomShop.Server.Data;
using AmazoomShop.Server.Services.CategoryService;
using AmazoomShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazoomShop.Server.Services.ProductService
{
    public class ProductService : iProductService
    {
        private readonly iCategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(iCategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }


        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async  Task<List<Product>> GetProductsByCategorys(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        //public List<Product> Products { get; set; } = new List<Product>();
    }
}
