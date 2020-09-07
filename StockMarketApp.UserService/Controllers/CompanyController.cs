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
    public class CompanyController : ControllerBase
    {
        private IRepository<Company> repository;

        public CompanyController(IRepository<Company> repository)
        {
            this.repository = repository;
        }

        [HttpGet("getAllCompanies")]
        public IEnumerable<Company> Get()
        {
            return repository.Get();
        }

        [HttpGet("{Id}")]
        public Company GetCompany(int Id)
        {
            return repository.Get(Id);
        }

        
        [HttpPost]
        [Route("GetMatchingCompanies")]
        public IEnumerable<Company> Post([FromForm] string str)
        {
            return repository.GetMatchingCompanies(str);
        }
        

        


        }
}
