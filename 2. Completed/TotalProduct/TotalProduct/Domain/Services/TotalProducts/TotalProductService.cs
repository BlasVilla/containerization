using System;
using System.Linq;
using System.Threading.Tasks;
using TotalProduct.Domain.Services.Pricing;
using TotalProduct.Domain.Services.Products;
using TotalProduct.Models;
using TotalProduct.Models.Pricing;
using TotalProduct.Models.Prooducts;

namespace TotalProduct.Domain.Services.TotalProducts
{
    public class TotalProductService : ITotalProductService
    {
        private readonly IProductService productService;
        private readonly IPriceService priceService;

        public TotalProductService(IProductService productService, IPriceService priceService)
        {
            this.productService = productService;
            this.priceService = priceService;
        }

        public async Task<CombinedProduct[]> GetAll()
        {
            var productsTask = productService.GetAll();

            var pricesTask = priceService.GetAll();

            await Task.WhenAll(productsTask, pricesTask);

            var products = productsTask.Result;

            var prices = pricesTask.Result;

            return products
                .Select(product => Combine(product, prices.SingleOrDefault(p => p.Code == product.Code)))
                .ToArray();
        }

        public async Task<CombinedProduct> GetById(string code)
        {
            var productTask = productService.GetById(code);

            var priceTask = priceService.GetById(code);

            await Task.WhenAll(productTask, priceTask);

            var product = productTask.Result;

            var price = priceTask.Result;

            return Combine(product, price);
        }

        protected static CombinedProduct Combine(Product product, ProductPrice price)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            if (price == null)
            {
                throw new ArgumentNullException(nameof(price));
            }

            return new CombinedProduct
            {
                Code = product.Code,
                Name = product.Name,
                Description = product.Description,
                Categories = product.Categories,
                Price = price.Price
            };
        }
    }
}
