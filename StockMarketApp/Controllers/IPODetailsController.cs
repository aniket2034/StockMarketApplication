using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.AdminService.Repository;
using StockMarketLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMarketApp.AdminService.Controllers
{
    [Route("api/Admin/[controller]")]
    [ApiController]
    public class IPODetailsController : ControllerBase
    {

        private IRepository<IPODetails> repository;

        public IPODetailsController(IRepository<IPODetails> repository)
        {
            this.repository = repository;
        }


        [HttpPost]
        public IActionResult Post([FromBody] IPODetailsDto entity)
        {
            if (ModelState.IsValid)
            {
                var new_item = new IPODetails
                {
                    PricePerShare = entity.pricePerShare,
                    TotalNumberOfShares = entity.totalNumberShares,
                    OpenDateTime = Convert.ToDateTime(entity.date + " " + entity.time),
                    Remarks = entity.remarks,
                    CompanyId = entity.companyId,
                    StockExchangeId = entity.stockExchangeId
                };
                var isAdded = repository.add(new_item);
                if (isAdded)
                {
                    return Created("IPODETAILS", new_item);
                }
            }
            return BadRequest(ModelState);
        }



    }
}
