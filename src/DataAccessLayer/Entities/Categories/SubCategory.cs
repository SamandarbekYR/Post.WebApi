using DataAccessLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Categories
{
    public class Subcategory : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
        public IEnumerable<Product> Subcategories = new List<Product>();
    }
}
