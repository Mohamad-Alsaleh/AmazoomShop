using AmazoomShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazoomShop.Client.Services.CategoryService
{
    interface iCategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();

    }
}
