using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLibrary
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SectorName { get; set; }
        public string Brief { get; set; }

        public virtual ICollection<Company> Company { get; set; }

    }
}
