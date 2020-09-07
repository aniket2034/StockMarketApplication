using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.UserService.Repository;
using StockMarketLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMarketApp.UserService.Controllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class StockExchangeController : ControllerBase
    {

        private IStockExchangeRepository<StockExchange> repository;

        public StockExchangeController(IStockExchangeRepository<StockExchange> repository)
        {
            this.repository = repository;
        }

        // GET: api/<StockExchangeController>
        [HttpGet("getAllStockExchanges")]
        public IEnumerable<StockExchange> Get()
        {
            return repository.Get();
        }

        [HttpGet("{Id}")]
       public IEnumerable<Object> GetCompanies(string Id)
        {
            return repository.GetCompanies(Id);
        }

       
    }
}
