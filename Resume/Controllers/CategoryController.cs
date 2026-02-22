using Microsoft.AspNetCore.Mvc;
using Resume.Data;
using Resume.Repository;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Resume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {

        private readonly ProductServiceBase _method;
        public CategoryController(ProductServiceBase method)
        {
            _method = method;
        }


        [HttpGet("GetByCategory")]
        public IActionResult GetByCategory()
        {
           var result =  _method.GetByCategory();
            return Ok(result);

        }

        [HttpGet("GetByCategorySpecifically")]
        public IActionResult GetByCategorySpecifically([FromQuery] Categories categories)
        {
         // specific urls based on the Category data
        //http://localhost:5252/category/GetByCategorySpecifically?categories=Category1
        //http://localhost:5252/category/GetByCategorySpecifically?categories=Category2
        //http://localhost:5252/category/GetByCategorySpecifically?categories=Category3


            var result = _method.GetByCategorySpecifically(categories);
            return Ok(result);
        }

        [HttpGet("GetHighestPrice")]
        public IActionResult HighestPrice()
        {
            var result = _method.HighestPrice();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("GetTotalPrice")]
        public IActionResult GetTotalPrice()
        {
            var ProductWithHighestPrice = _method.GetTotalPrice();
            return Ok(ProductWithHighestPrice);
        }

        [HttpGet("GetCategoryByGroup")]

        public IActionResult GetCategoryByGroup()
        {
            var result = _method.GetCategoryByGroup();
            return Ok(result);
        }

        [HttpGet("GetAveragePrice")]

        public IActionResult GetAveragePrice()
        {
            var result = _method.GetAveragePrice();
            return Ok(result);
        }

    }
}
