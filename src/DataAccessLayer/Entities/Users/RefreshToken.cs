using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Users
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; } = string.Empty;
        public string JwtId { get; set; } = string.Empty;
        public bool IsRevoked { get; set; }
        [StringLength(50)]
        public string DateAdded { get; set; } = string.Empty;
        [StringLength(50)]
        public string DataExpire { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
    }
}
