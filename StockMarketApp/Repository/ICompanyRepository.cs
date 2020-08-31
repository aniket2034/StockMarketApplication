using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Get();

        Company Get(int key);

        bool add(Company entity);

        bool Update(Company entity);

        bool Delete(Company entity);

        //IEnumerable<Company> Get(string str);

    }
}
