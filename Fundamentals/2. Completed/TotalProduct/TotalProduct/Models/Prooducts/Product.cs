namespace TotalProduct.Models.Prooducts
{
    public class Product
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategories[] Categories { get; set; }
    }
}
