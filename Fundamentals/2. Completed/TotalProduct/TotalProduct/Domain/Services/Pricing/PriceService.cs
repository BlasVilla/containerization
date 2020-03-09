using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TotalProduct.Models.Pricing;

namespace TotalProduct.Domain.Services.Pricing
{
    public class PriceService : IPriceService
    {
        private const string Route = @"api/prices";

        private readonly HttpClient httpClient;

        public PriceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ProductPrice[]> GetAll()
        {
            ProductPrice[] result;
            
            var response = await httpClient.GetAsync(Route);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<ProductPrice[]>(responseString);
            }
            else
            {
                result = null;
            }

            return result;
        }

        public async Task<ProductPrice> GetById(string code)
        {
            ProductPrice result;
            
            var response = await httpClient.GetAsync($"{Route}/{code}");

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<ProductPrice>(responseString);
            }
            else
            {
                result = null;
            }

            return result;
        }
    }
}
