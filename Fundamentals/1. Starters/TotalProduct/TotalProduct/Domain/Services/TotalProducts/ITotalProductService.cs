using System.Threading.Tasks;
using TotalProduct.Models;

namespace TotalProduct.Domain.Services.TotalProducts
{
    public interface ITotalProductService
    {
        Task<CombinedProduct[]> GetAll();

        Task<CombinedProduct> GetById(string code);
    }
}
