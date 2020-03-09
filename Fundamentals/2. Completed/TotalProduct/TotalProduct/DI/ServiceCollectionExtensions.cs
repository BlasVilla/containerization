using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TotalProduct.Domain.Services.Pricing;
using TotalProduct.Domain.Services.Products;
using TotalProduct.Domain.Services.TotalProducts;

namespace TotalProduct.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var productServiceUrl = configuration["Services:ProductService"];
            var pricingServiceUrl = configuration["Services:ProductPriceService"];

            Console.WriteLine($"Product Service: {productServiceUrl}");

            Console.WriteLine($"Pricing Service: {pricingServiceUrl}");

            services
                .AddHttpClient<IProductService, ProductService>(client =>
                    client.BaseAddress = new Uri(productServiceUrl));

            services
                .AddHttpClient<IPriceService, PriceService>(client =>
                    client.BaseAddress = new Uri(pricingServiceUrl));

            return services
                .AddTransient<ITotalProductService, TotalProductService>();
        }
    }
}
