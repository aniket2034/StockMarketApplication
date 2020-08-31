using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public interface IStockExchangeRepository
    {
        IEnumerable<StockExchange> Get();
        bool add(StockExchange entity);
    }
}
