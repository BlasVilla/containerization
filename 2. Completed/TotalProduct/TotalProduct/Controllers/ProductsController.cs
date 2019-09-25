using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TotalProduct.Domain.Services.TotalProducts;
using TotalProduct.Models;

namespace TotalProduct.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly ITotalProductService service;

        public ProductsController(ITotalProductService service)
        {
            this.service = service;
        }

        [HttpGet()]
        public async Task<CombinedProduct[]> GetAll()
        {
            return await service.GetAll();
        }
    }
}
