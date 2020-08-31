using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketApp.AdminService.Models;
using StockMarketLib;


namespace StockMarketApp.AdminService.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private AdminContextDB context;

        public CompanyRepository(AdminContextDB context)
        {
            this.context = context;
        }

        public bool add(Company entity)
        {
            try
            {
                context.Company.Add(entity);
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

        public bool Delete(Company entity)
        {
            try
            {
                context.Company.Remove(entity);
                var updates = context.SaveChanges();
                if (updates > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Company> Get()
        {
            return context.Company;
        }

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


        public Company Get(int key)
        {
            var company = context.Company.Find(key);
            return company;
        }

    }
}
