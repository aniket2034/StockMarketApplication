using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockMarketLibrary
{
    public class IPODetailsDto
    {
        
        [Required]
        public double pricePerShare { get; set; }
        [Required]
        public int totalNumberShares { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string time { get; set; }
        public string remarks { get; set; }

       
        public int companyId { get; set; }
        public string stockExchangeId { get; set; }
    }
}
