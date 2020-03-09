using Products.Models;

namespace Products.Dummy
{
    public static class DummyProducts
    {

        public static Product[] CreateDummyProducts()
        {
            return new Product[] 
            {
                new Product 
                {
                    Code = "Socks123",
                    Name = "Awesome socks",
                    Description = "Suspendisse in congue mauris. Nam volutpat lobortis quam vitae cursus. Sed a sagittis lectus, eget varius risus. Morbi posuere suscipit libero vitae maximus. Vivamus vulputate eu justo id dignissim. Etiam id massa a nulla feugiat varius vitae ut elit. Sed sagittis, quam quis facilisis ultrices, augue turpis ultrices tellus, vel ornare lacus turpis nec massa. Fusce malesuada faucibus nisi, elementum convallis justo condimentum mattis.",
                    Categories = new [] { 
                        ProductCategories.Winter, 
                        ProductCategories.Men, 
                        ProductCategories.Women, 
                        ProductCategories.Casual 
                        }
                },
                new Product
                {
                    Code = "Jeans3444",
                    Name = "Torn jeans",
                    Description = "Maecenas eros felis, lobortis eget urna nec, commodo semper turpis. Duis iaculis et massa ac molestie. Nam sagittis pulvinar leo, sit amet malesuada orci ultrices non. Sed ultrices est at eros congue, id scelerisque nunc fermentum. Integer ac mattis erat, eu venenatis ex. Etiam semper erat felis, ac efficitur lorem faucibus in. Cras eget pharetra purus, efficitur malesuada nunc. Curabitur metus orci, rutrum ac luctus ac, blandit a tellus.",
                    Categories = new [] {
                        ProductCategories.Women,
                        ProductCategories.Casual }
                },
                new Product
                {
                    Code = "Pants431",
                    Name = "Fancy pants",
                    Description = "Donec eget semper lectus, vel suscipit augue. Duis condimentum, lectus vitae ultrices facilisis, velit sem aliquet neque, eget cursus quam lacus vel est. Proin nec lorem dolor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. In quam massa, pulvinar vel eros et, condimentum scelerisque nisi. Etiam porta imperdiet ex, vitae euismod mi efficitur at. Duis sed arcu et mauris vestibulum faucibus. Proin in tempor metus. Morbi hendrerit velit malesuada magna aliquam mattis. Vivamus libero dui, consequat ut augue at, tincidunt condimentum metus. Mauris molestie neque a orci consequat ultricies. Morbi sit amet mollis tellus.",
                    Categories = new [] {
                        ProductCategories.Women,
                        ProductCategories.Sportive }
                },
            };
        }
    }
}
