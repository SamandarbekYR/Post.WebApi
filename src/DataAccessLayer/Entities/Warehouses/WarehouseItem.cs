using DataAccessLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Werhouses
{
    public class WarehouseItem : BaseEntity
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        [StringLength(30)]
        public string BroughtDate { get; set; } = string.Empty;
        [Required]
        public decimal IncomingPrice { get; set; }
        [Required]
        public decimal SellingPrice { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
        [Required]
        public string AdminId { get; set; } = string.Empty;
        [Required]
        public int WarehouseId { get; set; }
    }
}
