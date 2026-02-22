using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Resume.Data;


namespace Resume.Repository
{
    public abstract class ProductServiceBase
    {
        //var data = new Datas();
        protected Productore data = new Productore();

        public abstract IEnumerable<Product> GetByCategory();
        public abstract IEnumerable<Product> GetByCategorySpecifically(Categories categories);


        public virtual double GetTotalPrice()
        {
            return data.products.Sum(p => p.Price);
        }

        public abstract IEnumerable<IGrouping<Categories, Product>> GetCategoryByGroup();
        public abstract double GetAveragePrice();
        public abstract Product? HighestPrice();






    }
}
