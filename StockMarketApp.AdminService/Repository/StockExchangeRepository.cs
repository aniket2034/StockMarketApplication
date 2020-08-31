using StockMarketApp.AdminService.Models;
using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class StockExchangeRepository : IStockExchangeRepository
    {
        private AdminContextDB context;

        public StockExchangeRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool add(StockExchange entity)
        {
            try
            {
                //insert 
                
                context.StockExchange.Add(entity);
                int updates = context.SaveChanges();
                if (updates > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<StockExchange> Get()
        {
            return context.StockExchange;
        }
    }
}
