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
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public UserType UserType { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
       
        public bool Confirmed { get; set; }
    }
}
