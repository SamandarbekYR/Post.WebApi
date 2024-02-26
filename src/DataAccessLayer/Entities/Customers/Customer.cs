using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities.Customers
{
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
