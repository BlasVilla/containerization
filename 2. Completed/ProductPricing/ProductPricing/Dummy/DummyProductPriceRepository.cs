using ProductPricing.Domain;
using ProductPricing.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPricing.Dummy
{
    public class DummyProductPriceRepository : IProductPriceRepository
    {
        private readonly IDictionary<string, ProductPrice> _prices;

        public DummyProductPriceRepository()
        {
            var prices = DummyProductPrices.CreateAll();

            _prices = prices.ToDictionary(p => p.Code, p => p);
        }

        public Task<ProductPrice[]> GetAll()
        {
            var prices = _prices.Values.ToArray();

            return Task.FromResult(prices);
        }

        public Task<ProductPrice> GetById(string code)
        {
            var price = _prices.ContainsKey(code) ? _prices[code] : null;

            return Task.FromResult(price);
        }
    }
}
