using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Resume.Data;

namespace Resume.Repository
{
    public class ProductService : ProductServiceBase
    {
        public override IEnumerable<Product> GetByCategory()
        {
            return data.products.Where(p => p.Category == Categories.Category1);
        }

        public override IEnumerable<Product> GetByCategorySpecifically(Categories categories)
        {
            return data.products.Where(p => p.Category == categories).ToList();
        }


        public override Product? HighestPrice()
        {
            if (!data.products.Any())
                return null;
            return data.products.MaxBy(p => p.Price);
        }

        public override IEnumerable<IGrouping<Categories, Product>> GetCategoryByGroup()
        {
            return  data.products.GroupBy(p => p.Category);
        }

        public override double GetAveragePrice()
        {
            if (!data.products.Any())
                return 0;
            return data.products.Average(p => p.Price);
        }
 

    }
}
