using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Users
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; } = string.Empty;
    }
}
