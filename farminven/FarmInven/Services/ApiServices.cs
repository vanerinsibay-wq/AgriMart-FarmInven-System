using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FarmInven.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
        }

        public async Task<string> GetProducts()
        {
            var response = await _client.GetAsync("http://127.0.0.1:5000/api/products");
            return await response.Content.ReadAsStringAsync();
        }
    }
}