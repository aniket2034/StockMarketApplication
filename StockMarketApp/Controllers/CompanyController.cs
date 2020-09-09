using Microsoft.AspNetCore.Mvc;
using StockMarketApp.AdminService.Repository;
using StockMarketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.AdminService.Controllers
{
    [Route("api/Admin/[controller]")]
    [ApiController]
    public class CompanyController: ControllerBase
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


        [HttpPut("updateCompany/{id}")]
        public IActionResult Put(int id, [FromBody] Company company)
        {
            
            if (ModelState.IsValid)
            {
                if (id == company.Id)
                {
                
                    var existing = repository.Get(company.Id);
                    if (existing == null)
                    {
                        return NotFound();
                    }

                    var isUpdated = repository.Update(existing,company);
                    if (isUpdated)
                    {
                        return Ok(company);
                    }
                }
            }
            return BadRequest(ModelState);
        }

        
        [HttpDelete("deleteCompany/{id}")]
        public IActionResult Delete(int id)
        {
            var company = repository.Get(id);
            if (company == null)
            {
                return NotFound();
            }
            var isDeleted = repository.Delete(company);
            if (isDeleted)
            {
                return Ok("Company deleted successfully");
            }
            return StatusCode(500, "Internal server error");
        }

        [HttpPost("addCompany")]
        public IActionResult Post([FromBody] Company company)
        {
            if (ModelState.IsValid)
            {
                var isAdded = repository.add(company);
                if (isAdded)
                {
                    return Created("Company", company);
                }
            }
            return BadRequest(ModelState);
        }





    }
}
