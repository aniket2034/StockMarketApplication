using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Get();
        IEnumerable<Company> GetMatchingCompanies(string str);

        Company GetCompany(int Id);

        //IEnumerable<Object> GetCompanyStockPrice(int Id, string to, string from, int periodicity);

    }
}
