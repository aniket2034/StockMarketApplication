using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketApp.Dtos
{
    public class StockPriceDto
    {
        public int Id { get; set; }
        [Required]
        public decimal CurrentPrice { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string StockExchangeCode { get; set; }
    }
}
