using Microsoft.AspNetCore.Mvc;
using Products.Domain;
using Products.Models;
using System.Threading.Tasks;

namespace Products.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository repository;

        public ProductsController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public async Task<Product[]> GetAll()
        {
            return await repository.GetAll();
        }

        [HttpGet("{code}")]
        [Produces(typeof(Product))]
        public async Task<IActionResult> GetById([FromRoute] string code)
        {
            var product = await repository.GetById(code);

            return product != null ? (IActionResult)Ok(product) : NotFound();
        }
    }
}
