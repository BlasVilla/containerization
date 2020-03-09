using System.Threading.Tasks;
using TotalProduct.Models.Prooducts;

namespace TotalProduct.Domain.Services.Products
{
    public interface IProductService
    {
        Task<Product[]> GetAll();

        Task<Product> GetById(string code);
    }
}
