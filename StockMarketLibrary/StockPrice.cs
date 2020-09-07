using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLibrary
{
    public class StockPrice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal CurrentPrice { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public string StockExchangeId { get; set; }
        public virtual StockExchange StockExchange { get; set; }
        public virtual StockExchangeCompanies StockExchangeCompanies { get; set; }
    }
}
