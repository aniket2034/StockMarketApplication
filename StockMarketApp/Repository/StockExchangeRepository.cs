using StockMarketApp.AdminService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class StockExchangeRepository : IRepository<StockExchange>
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

     
        public bool Delete(StockExchange entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockExchange> Get()
        {
            return context.StockExchange;
        }

        public StockExchange Get(object key)
        {
            return context.StockExchange.Where(c => c.id == key.ToString()).Single();

        }

        public bool Update(StockExchange existing, StockExchange entity)
        {
            throw new NotImplementedException();
        }
    }
}
