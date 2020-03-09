using ProductPricing.Models;
using System.Threading.Tasks;

namespace ProductPricing.Domain
{
    public interface IProductPriceRepository
    {
        Task<ProductPrice[]> GetAll();

        Task<ProductPrice> GetById(string code);
    }
}
