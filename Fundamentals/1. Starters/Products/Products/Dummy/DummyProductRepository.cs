using Products.Domain;
using Products.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Dummy
{
    public class DummyProductRepository : IProductRepository
    {
        private static readonly IReadOnlyDictionary<string, Product> _products;

        static DummyProductRepository()
        {
            var products = DummyProducts.CreateDummyProducts();

            _products = products.ToDictionary(p => p.Code, p => p);
        }

        public Task<Product[]> GetAll()
        {
            var products = _products.Values.ToArray();

            return Task.FromResult(products);
        }

        public Task<Product> GetById(string code)
        {
            var product = _products[code];

            return Task.FromResult(product);
        }
    }
}
