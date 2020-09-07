using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();

        T Get(object key);

        bool add(T entity);

        bool Update(T existing,T entity);

        bool Delete(T entity);
        
        //IEnumerable<Company> Get(string str);

    }
}
