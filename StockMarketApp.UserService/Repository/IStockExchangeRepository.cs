using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public interface IStockExchangeRepository
    {
        IEnumerable<StockExchange> Get();

        IEnumerable<Object> GetCompanies(int id);

    }
}
