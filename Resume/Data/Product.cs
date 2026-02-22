using Resume.Data;
using System.Runtime.InteropServices.ComTypes;

namespace Resume.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        
        public int Price { get; set; }
    }
}
