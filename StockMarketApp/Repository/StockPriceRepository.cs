using StockMarketApp.AdminService.Models;
using StockMarketApp.Dtos;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class StockpriceRepository : IRepository<StockPriceDto>
    {
        private AdminContextDB context;
        public StockpriceRepository(AdminContextDB context)
        {
            this.context = context;
        }
        public bool Add(StockPriceDto entity)
        {
            try
            {
                var stockprice = new StockPrice
                {
                    CurrentPrice = entity.CurrentPrice
                    
                    //Company = context.Companies.Find(entity.CompanyId),
                    //StockExchange = context.StockExchanges.Find(entity.StockExchangeCode)
                };
                context.StockPrice.Add(stockprice);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(StockPriceDto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockPriceDto> Get()
        {
            var stockprices = new List<StockPriceDto>();
            foreach (var stockPrice in context.StockPrice)
            {
                stockprices.Add(new StockPriceDto
                {
                    Id = stockPrice.Id,
                    CurrentPrice = stockPrice.CurrentPrice,
                    DateTime = DateTime.Parse(stockPrice.Date + ' ' + stockPrice.Time),
                    CompanyId = stockPrice.StockExchangeCompanies.CompanyId,
                    StockExchangeCode = stockPrice.StockExchangeCompanies.StockExchangeId
                });
            }

            return stockprices;
        }

        public StockPriceDto Get(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(StockPriceDto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockPrice> Get(DateTime fromDate, DateTime to,
            int companyId, string stockExchangeCode)
        {
            var stockPrices = context.StockPrice.Where(s =>
                s.StockExchangeCompanies.CompanyId == companyId &&
                s.StockExchangeCompanies.StockExchangeId == stockExchangeCode &&
                Convert.ToDateTime(s.Date + ' ' + s.Time) >= fromDate &&
                Convert.ToDateTime(s.Date + ' ' + s.Time) <= to);

            var sp = from s in context.StockPrice
                     where s.StockExchangeCompanies.CompanyId == companyId &&
                    s.StockExchangeCompanies.StockExchangeId == stockExchangeCode &&
                    Convert.ToDateTime(s.Date + ' ' + s.Time) >= fromDate &&
                    Convert.ToDateTime(s.Date + ' ' + s.Time) <= to
                     select s;

            return stockPrices;
        }

        

        public bool add(StockPriceDto entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(StockPriceDto existing, StockPriceDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
