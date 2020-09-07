using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using StockMarketApp.UserService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public class StockExchangeRepository : IStockExchangeRepository<StockExchange>
    {
        private UserContextDB context;

        public StockExchangeRepository(UserContextDB context)
        {
            this.context = context;
        }

        public IEnumerable<StockExchange> Get()
        {
            return context.StockExchange;
        }


        IEnumerable<Object> IStockExchangeRepository<StockExchange>.GetCompanies(string id)
        {
            var query = from article in context.Company
                        where article.StockExchangeCompanies.Any(c => c.StockExchangeId == id)
                        select article;

            return query;
        }
    }
}
