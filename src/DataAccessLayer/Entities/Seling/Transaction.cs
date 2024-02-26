using DataAccessLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Seling
{
    public class Transaction : BaseEntity
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        [Required]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; } = new Receipt();
    }
}
