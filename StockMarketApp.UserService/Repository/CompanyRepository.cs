using StockMarketApp.UserService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public class CompanyRepository : IRepository<Company>
    {
        private UserContextDB context;

        public CompanyRepository(UserContextDB context)
        {
            this.context = context;
        }

        public IEnumerable<Company> Get()
        {
            return context.Company;   
        }

        public IEnumerable<Company> GetMatchingCompanies(string str)
        {
            str = str.ToLower();
            var ans = from names in context.Company
                      where names.name.ToLower().StartsWith(str)
                      select names;

            return ans;
        }

        public Company Get(int id)
        { 
            var ans = context.Company.Where(c => c.Id == id).Single();
            return ans;
        }

        /*public IEnumerable<StockPrice> GetCompanyStockPrice(int Id, string to, string from, int periodicity)
        {
            throw new NotImplementedException();
        }*/
    }
}
