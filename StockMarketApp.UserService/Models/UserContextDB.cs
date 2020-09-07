using Microsoft.EntityFrameworkCore;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Models
{
    public class UserContextDB: DbContext
    {
        public UserContextDB([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected UserContextDB()
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
