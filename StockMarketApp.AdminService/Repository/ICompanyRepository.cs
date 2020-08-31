using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public interface ICompanyRepository<T>
    {
        IEnumerable<T> Get();

        T Get(int key);

        bool add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        //IEnumerable<Company> Get(string str);

    }
}
