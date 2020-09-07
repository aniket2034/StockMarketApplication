using StockMarketApp.AdminService.Models;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class SectorRepository : IRepository<Sector>
    {
        private AdminContextDB context;

        public SectorRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool add(Sector entity)
        {
            try
            {
                context.Sector.Add(entity);
                int updates = context.SaveChanges();
                if (updates > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Sector entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> Get()
        {
            return context.Sector;
        }

        public Sector Get(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sector existing, Sector entity)
        {
            throw new NotImplementedException();
        }
    }
}
