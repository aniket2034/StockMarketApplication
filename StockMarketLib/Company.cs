using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLib
{
    public class Company
    {

        public Company()
        {
            StockPrices = new HashSet<StockPrice>();
            StockExchangeCompanies = new HashSet<StockExchangeCompanies>();
        }

        [Key]
            public int Id { get; set; }
            [Required]
            
            public string CompanyName { get; set; }
            public decimal Turnover { get; set; }
            public string CEO { get; set; }
            public string BoardOfDirectors { get; set; }
            public string Brief { get; set; }
       
            //navigation properties
            public virtual IPODetails IPODetails { get; set; }
            public virtual ICollection<StockPrice> StockPrices { get; set; }

            public int SectorId { get; set; }
            public virtual Sector Sector { get; set; }

            public virtual ICollection<StockExchangeCompanies> StockExchangeCompanies { get; set; }

               
           
        
    }

}