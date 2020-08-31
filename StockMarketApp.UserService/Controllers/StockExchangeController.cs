using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.UserService.Repository;
using StockMarketLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMarketApp.UserService.Controllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class StockExchangeController : ControllerBase
    {

        private IStockExchangeRepository repository;

        public StockExchangeController(IStockExchangeRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/<StockExchangeController>
        [HttpGet]
        public IEnumerable<StockExchange> Get()
        {
            return repository.Get();
        }

        [HttpGet("{Id}")]
       public IEnumerable<Company> GetCompanies(int Id)
        {
            return repository.GetCompanies(Id);
        }

       
    }
}
