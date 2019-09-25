using Products.Models;
using System.Threading.Tasks;

namespace Products.Domain
{
    public interface IProductRepository
    {
        Task<Product[]> GetAll();

        Task<Product> GetById(string code);
    }
}
