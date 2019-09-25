using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TotalProduct.Domain.Services.Pricing;
using TotalProduct.Domain.Services.Products;

namespace TotalProduct.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddHttpClient<IProductService, ProductService>(client =>
                    client.BaseAddress = new Uri(configuration["Services:ProductService"]));

            services
                .AddHttpClient<IPriceService, PriceService>(client =>
                    client.BaseAddress = new Uri(configuration["Services:ProductPriceService"]));

            return services;
        }
    }
}
