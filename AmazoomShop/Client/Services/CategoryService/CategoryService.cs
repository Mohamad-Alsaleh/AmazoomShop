using AmazoomShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;



namespace AmazoomShop.Client.Services.CategoryService
{
    public class CategoryService : iCategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get ; set ; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
           _http = http;
        }

        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
            
        }
    }
}
