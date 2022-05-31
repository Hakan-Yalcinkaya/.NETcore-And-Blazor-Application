using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{



    public class CategoryService : ICategoryService
    {
        HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public Task<CategoryListViewModel[]> GetCategories()
        {
            return _http.GetFromJsonAsync<CategoryListViewModel[]>("https://localhost:44383/api/categories/getall");
        }
    }
}
