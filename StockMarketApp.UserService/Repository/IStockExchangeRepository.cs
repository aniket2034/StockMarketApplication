using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public interface IStockExchangeRepository<T>
    {
        IEnumerable<T> Get();

        IEnumerable<Object> GetCompanies(string id);

    }
}
