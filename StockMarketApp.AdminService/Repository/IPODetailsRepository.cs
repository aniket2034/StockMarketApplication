using Microsoft.EntityFrameworkCore;
using StockMarketApp.AdminService.Models;
using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public class IPODetailsRepository: IIPODetailsRepository
    {
        private AdminContextDB context;

        public IPODetailsRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool Add(IPODetails entity)
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

        /*
        public bool Update(Company entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                var updates = context.SaveChanges();
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
        */
    }
}
