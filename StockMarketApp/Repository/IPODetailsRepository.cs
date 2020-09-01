

using Microsoft.EntityFrameworkCore;
using StockMarketApp.AdminService.Models;
using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class IPODetailsRepository: IRepository<IPODetails>
    {
        private AdminContextDB context;

        public IPODetailsRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool add(IPODetails entity)
        {
            try
            {
                //insert 
                context.IPODetails.Add(entity);
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

        public bool Delete(IPODetails entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPODetails> Get()
        {
            return context.IPODetails;
        }

        public IPODetails Get(object key)
        {
            return context.IPODetails.Where(c => c.Id == Convert.ToInt32(key)).Single();
        }

        public bool Update(IPODetails existing, IPODetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
