using StockMarketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Repository
{
    public interface IIPODetailsRepository
    { 

        //bool update(IPODetails entity);
        bool Add(IPODetails ip);
    }
}
