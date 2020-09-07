using StockMarketApp.UserService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.UserService.Repository
{
    public class SectorRepository : IRepository<Sector>
    {
        private UserContextDB context;

        public SectorRepository(UserContextDB context)
        {
            this.context = context;
        }

        public IEnumerable<Sector> Get()
        {
            return context.Sector;
        }

        public Sector Get(int Id)
        {
            var ans = context.Sector.Where(c => c.Id == Id).Single();
            return ans;
        }

        public IEnumerable<Sector> GetMatchingCompanies(string str)
        {
            throw new NotImplementedException();
        }
    }
}
