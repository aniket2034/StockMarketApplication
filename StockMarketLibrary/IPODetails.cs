﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketLibrary
{
    public class IPODetails
    {
        [Key]
        public int Id { get; set; }
        public float PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public string OpenDateTime { get; set; }
        public string Remarks { get; set; }
       
       

        //[ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public string StockExchangeId { get; set; }
        public virtual StockExchange StockExchange { get; set; }



    }
}
