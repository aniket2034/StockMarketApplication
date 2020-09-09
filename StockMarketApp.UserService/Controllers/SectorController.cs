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
    public class SectorController : ControllerBase
    {
        private IRepository<Sector> repository;

        public SectorController(IRepository<Sector> repository)
        {
            this.repository = repository;
        }

        [HttpGet("getAllSectors")]
        public IEnumerable<Sector> Get()
        {
            return repository.Get();
        }

        // GET api/<SectorController>/id
        [HttpGet("{id}")]
        public Sector Get(int id)
        {
            return repository.Get(id);
        }

      

        
    }
}
