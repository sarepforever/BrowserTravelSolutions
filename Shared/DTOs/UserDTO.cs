using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTravel.Shared.DTOs
{
    public class UserInfo
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool type { get; set; } = true;
    }
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
