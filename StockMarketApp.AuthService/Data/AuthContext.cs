using Microsoft.EntityFrameworkCore;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AuthService.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected AuthContext()
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
