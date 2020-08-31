using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLib
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public enum UserType
        {
            Admin=1,
            User
        }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public bool Confirmed { get; set; }
    }
}
