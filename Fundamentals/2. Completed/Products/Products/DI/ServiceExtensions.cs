using Microsoft.Extensions.DependencyInjection;
using Products.Domain;
using Products.Dummy;

namespace Products.DI
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            return services
                .AddSingleton<IProductRepository, DummyProductRepository>();
        }
    }
}
