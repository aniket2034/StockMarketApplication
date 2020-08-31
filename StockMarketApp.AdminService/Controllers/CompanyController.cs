using Microsoft.AspNetCore.Mvc;
using StockMarketApp.AdminService.Repository;
using StockMarketLib;
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
        private ICompanyRepository repository;

        public CompanyController(ICompanyRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("GetCompany")]
        public IEnumerable<Company> Get()
        {
            return repository.Get();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] Company company)
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

                    var isUpdated = repository.Update(company);
                    if (isUpdated)
                    {
                        return Ok(company);
                    }
                }
            }
            return BadRequest(ModelState);
        }

        
        [HttpDelete("{id}")]
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

        [HttpPost]
        public IActionResult Post([FromForm] Company company)
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
