using Microsoft.Extensions.DependencyInjection;
using ProductPricing.Domain;
using ProductPricing.Dummy;

namespace ProductPricing.DI
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            return services
                .AddSingleton<IProductPriceRepository, DummyProductPriceRepository>();
        }
    }
}
