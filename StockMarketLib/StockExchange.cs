using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLib
{
    public class StockExchange
    {
        public StockExchange()
        {
            IPODetails = new HashSet<IPODetails>();
            StockExchangeCompanies = new HashSet<StockExchangeCompanies>();
            StockPrices = new HashSet<StockPrice>();
        }

        [Key]
        public int Id { get; set; }
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
