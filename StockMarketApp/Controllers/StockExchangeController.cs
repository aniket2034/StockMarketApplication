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
    public class StockExchangeController : ControllerBase
    {

        private IRepository<StockExchange> repository;

        public StockExchangeController(IRepository<StockExchange> repository)
        {
            this.repository=repository;
        }


        // GET: api/<StockExchangeController>
        [HttpGet("getAllStockExchanges")]
        public IEnumerable<StockExchange> Get()
        {
            return repository.Get();
        }

        // POST api/<StockExchangeController>
        [HttpPost("addStockExchange")]
        public IActionResult Post([FromBody] StockExchange stock)
        {
            if (ModelState.IsValid)
            {
                var isAdded = repository.add(stock);
                if (isAdded)
                {
                    return Created("StockExchange", stock);
                }
            }
            return BadRequest(ModelState);
        }

        
    }
}
