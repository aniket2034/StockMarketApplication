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
    public class StockExchangeCompaniesController : ControllerBase
    {

        private IRepository<StockExchangeCompanies> repository;

        public StockExchangeCompaniesController(IRepository<StockExchangeCompanies> repository)
        {
            this.repository = repository;
        }


        // GET: api/<StockExchangeCompaniesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StockExchangeCompaniesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StockExchangeCompaniesController>
        [HttpPost]
        public IActionResult Post(StockCompanyDto entity)
        {
                StockExchangeCompanies s = new StockExchangeCompanies();
                s.CompanyId = Int16.Parse(entity.companyId);
                s.StockExchangeId = entity.stockExchangeId;

                var check = repository.add(s);

                if (check)
                    return Ok(s);

            return BadRequest();
           
        }

        // PUT api/<StockExchangeCompaniesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
    }
}
