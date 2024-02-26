using DataAccessLayer.Entities.Warehouses;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities.Seling
{
    public class Receipt : BaseEntity
    {
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public decimal PaidCash { get; set; }
        [Required]
        public decimal PaidCard { get; set; }
        [Required]
        public bool HasLoan { get; set; }

        [Required]
        public string SellerId { get; set; } = string.Empty;
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; } = new Warehouse();

        public IEnumerable<Transaction> Transactions = new List<Transaction>();
    }
}
