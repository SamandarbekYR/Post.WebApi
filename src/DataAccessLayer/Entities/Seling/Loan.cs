using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Seling
{
    public class Loan : BaseEntity
    {
        [Required]
        public decimal PaidCash { get; set; }
        [Required]
        public decimal PaidCard { get; set; }
        [Required]
        public decimal TotalPayment { get; set; }
        [Required]
        public decimal LeftAmount { get; set; }

        [Required]
        public int ReceiptId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string SellerId { get; set; } = string.Empty;


        public IEnumerable<LoanPayment> LoanPayments = new List<LoanPayment>();
    }
}
