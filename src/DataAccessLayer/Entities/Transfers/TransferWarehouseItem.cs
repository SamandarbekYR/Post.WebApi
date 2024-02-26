using DataAccessLayer.Entities.Werhouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Transfers
{
    public class TransferWarehouseItem : BaseEntity
    {
        public int TransferId { get; set; }
        public Transfer Transfer { get; set; } = new Transfer();
        public int WarehouseItemId { get; set; }
        public WarehouseItem WarehouseItem { get; set; } = new();
        public int Quantity { get; set; }
    }
}
