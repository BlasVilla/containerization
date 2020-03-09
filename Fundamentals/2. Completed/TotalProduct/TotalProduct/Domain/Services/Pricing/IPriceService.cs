using System.Threading.Tasks;
using TotalProduct.Models.Pricing;

namespace TotalProduct.Domain.Services.Pricing
{
    public interface IPriceService
    {
        Task<ProductPrice[]> GetAll();

        Task<ProductPrice> GetById(string code);
    }
}
