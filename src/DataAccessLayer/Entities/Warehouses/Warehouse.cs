using DataAccessLayer.Entities.Werhouses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Warehouses
{
    public class Warehouse : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<WarehouseItem> Items = new List<WarehouseItem>();
    }
}
