using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        IEnumerable<T> GetMatchingCompanies(string str);

        T Get(int Id);

        //IEnumerable<Object> GetCompanyStockPrice(int Id, string to, string from, int periodicity);

    }
}
