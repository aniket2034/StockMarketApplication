using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.AdminService.Repository;
using StockMarketLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMarketApp.AdminService.Controllers
{
    [Route("api/Admin/[controller]")]
    [ApiController]
    public class IPODetailsController : ControllerBase
    {

        private IIPODetailsRepository repository;

        public IPODetailsController(IIPODetailsRepository repository)
        {
            this.repository = repository;
        }


        [HttpPost]
        public IActionResult Post([FromForm] IPODetails ip)
        {
            if (ModelState.IsValid)
            {
                var isAdded = repository.Add(ip);
                if (isAdded)
                {
                    return Created("IPODETAILS", ip);
                }
            }
            return BadRequest(ModelState);
        }



    }
}
