
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using StockMarketLibrary;

namespace StockMarketApp.AdminService.Models
{
    public class AdminContextDB: DbContext
    {
        public AdminContextDB([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected AdminContextDB()
        {
        }

        public virtual DbSet<StockExchange> StockExchange { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<StockPrice> StockPrice { get; set; }
        public virtual DbSet<IPODetails> IPODetails { get; set; }

        public virtual DbSet<Sector> Sector { get; set; }

        public virtual DbSet<StockExchangeCompanies> StockExchangeCompanies { get; set; }
   
        public virtual DbSet<User> users { get; set; }
    }
}
