using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class BaseEntity
    {
        [Key, Required]
        public int Id { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
