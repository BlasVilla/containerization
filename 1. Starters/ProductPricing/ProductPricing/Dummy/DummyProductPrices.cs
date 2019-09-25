using ProductPricing.Models;

namespace ProductPricing.Dummy
{
    public static class DummyProductPrices
    {
        public static ProductPrice[] CreateAll()
        {
            return new[]
            {
                new ProductPrice
                {
                    Code = "Socks123",
                    Price = 3.05
                },
                new ProductPrice
                {
                    Code = "Jeans3444",
                    Price = 64.57
                },
                new ProductPrice
                {
                    Code = "Pants431",
                    Price = 34.56
                }
            };
        }
    }
}
