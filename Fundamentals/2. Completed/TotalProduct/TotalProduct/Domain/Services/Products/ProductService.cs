using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TotalProduct.Models.Prooducts;

namespace TotalProduct.Domain.Services.Products
{
    public class ProductService : IProductService
    {
        private const string Route = @"api/products";

        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Product[]> GetAll()
        {
            Product[] result;
            
            var response = await httpClient.GetAsync(Route);

            if(response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Product[]>(responseString);
            }
            else
            {
                result = null;
            }

            return result;
        }

        public async Task<Product> GetById(string code)
        {
            Product result;

            var response = await httpClient.GetAsync($"{Route}/{code}");

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Product>(responseString);
            }
            else
            {
                result = null;
            }

            return result;
        }
    }
}
