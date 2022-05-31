using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class ProductService : IProductService
    {
        HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task Add(ProductViewModel productViewModel)
        {
            await _http.PostAsJsonAsync("https://localhost:44383/api/products/add", productViewModel);
        }

        public Task<ProductViewModel> GetProductById(int productId)
        {
            return _http.GetFromJsonAsync<ProductViewModel>("https://localhost:44383/api/products/getbyid?productid="+productId);
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return  _http.GetFromJsonAsync<ProductListViewModel[]>("https://localhost:44383/api/products/getall");
        }

        public async Task Save(ProductViewModel productViewModel)
        {
            await _http.PostAsJsonAsync("https://localhost:44383/api/products/update", productViewModel);
        }
    }
}
