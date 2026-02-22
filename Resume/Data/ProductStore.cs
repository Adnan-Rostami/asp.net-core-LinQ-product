using Resume.Data;

namespace Resume.Data
{
    public class Productore
    {
        public List<Product> products { get; } = new List<Product>
{
 new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
 new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
 new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
 new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
 new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
};

    }
}
