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
    public class SectorController : ControllerBase
    {

        private IRepository<Sector> repository;

        public SectorController(IRepository<Sector> repository)
        {
            this.repository = repository;
        }

        // GET: api/<SectorController>
        [HttpGet]
        public IEnumerable<Sector> Get()
        {
            return repository.Get();
        }

        // GET api/<SectorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SectorController>
        [HttpPost]
        public IActionResult Post([FromBody] Sector value)
        {
            if (ModelState.IsValid)
            {
                var isAdded = repository.add(value);
                if (isAdded)
                {
                    return Created("Sector", value);
                }
            }
            return BadRequest(ModelState);
        }

        // PUT api/<SectorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SectorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
