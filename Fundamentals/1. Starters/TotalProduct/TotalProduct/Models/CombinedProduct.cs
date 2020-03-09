using TotalProduct.Models.Prooducts;

namespace TotalProduct.Models
{
    public class CombinedProduct
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategories[] Categories { get; set; }

        public double Price { get; set; }
    }
}
