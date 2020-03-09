using Microsoft.AspNetCore.Mvc;
using ProductPricing.Domain;
using ProductPricing.Models;
using System.Threading.Tasks;

namespace ProductPricing.Controllers
{
    [Route("api/prices")]
    public class PricesController : Controller
    {
        private readonly IProductPriceRepository repository;

        public PricesController(IProductPriceRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public async Task<ProductPrice[]> GetAll()
        {
            return await repository.GetAll();
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetById([FromRoute] string code)
        {
            var price = await repository.GetById(code);

            return price != null ? (IActionResult)Ok(price) : NotFound();
        }
    }
}
