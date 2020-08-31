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
    public class StockExchangeController : ControllerBase
    {

        private IStockExchangeRepository repository;

        public StockExchangeController(IStockExchangeRepository repository)
        {
            this.repository=repository;
        }


        // GET: api/<StockExchangeController>
        [HttpGet]
        [Route("GetStockExchange")]
        public IEnumerable<StockExchange> Get()
        {
            return repository.Get();
        }

        // POST api/<StockExchangeController>
        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult Post([FromBody] StockExchange stock)
        {
            if (ModelState.IsValid)
            {
                var isAdded = repository.add(stock);
                if (isAdded)
                {
                    return Created("student", stock);
                }
            }
            return BadRequest(ModelState);
        }

        
    }
}
