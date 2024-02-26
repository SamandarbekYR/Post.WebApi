using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Subcategory> Subcategories = new List<Subcategory>();
    }
}
