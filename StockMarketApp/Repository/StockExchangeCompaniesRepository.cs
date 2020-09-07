using StockMarketApp.AdminService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class StockExchangeCompaniesRepository : IRepository<StockExchangeCompanies>
    {

        private AdminContextDB context;

        public StockExchangeCompaniesRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool add(StockExchangeCompanies entity)
        {
            try
            {
                context.StockExchangeCompanies.Add(entity);
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

        public bool Delete(StockExchangeCompanies entity)
        {
            try
            {
                context.StockExchangeCompanies.Remove(entity);
                var updates = context.SaveChanges();
                if (updates > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<StockExchangeCompanies> Get()
        {
            throw new NotImplementedException();
        }

        public StockExchangeCompanies Get(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(StockExchangeCompanies existing, StockExchangeCompanies entity)
        {
            throw new NotImplementedException();
        }
    }
}
