using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Seling
{
    public class LoanPayment : BaseEntity
    {
        public decimal PaidCash { get; set; }
        public decimal PaidCard { get; set; }
        [Required]
        public decimal TotalPayment { get; set; }

        public int LoanId { get; set; }
        public Loan Loan { get; set; } = new Loan();
        public string SellerId { get; set; } = string.Empty;
    }
}
