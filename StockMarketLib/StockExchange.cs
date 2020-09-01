using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLib
{
    public class StockExchange
    {
        [Key]
        public string StockExchangeCode { get; set; }
        [Required]
       
        public string Name { get; set; }
        public string Brief { get; set; }
        public string ContactAddress { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<IPODetails> IPODetails { get; set; }
        public virtual ICollection<StockExchangeCompanies> StockExchangeCompanies { get; set; }
        public virtual ICollection<StockPrice> StockPrices { get; set; }
        

    }
}
