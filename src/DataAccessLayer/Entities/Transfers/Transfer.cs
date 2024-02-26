using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Transfers
{
    public class Transfer : BaseEntity
    {
        public int OutWarehouseId { get; set; }
        public int InWarehouseId { get; set; }
        public DateTime TransferDate { get; set; }
        public string AdminId { get; set; } = string.Empty;
        public int SupplierId { get; set; }
    }
}
