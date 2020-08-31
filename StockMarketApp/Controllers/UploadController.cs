using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.AdminService.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMarketApp.AdminService.Controllers
{
    [Route("api/Admin/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private IUploadRepository repository;

        public UploadController(IUploadRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Upload([FromForm] IFormFile file1)
        {
            if (file1 == null)
            {
                return BadRequest("must upload a file");
            }
            //check file extension

            try
            {
                var file = Request.Form.Files[0];
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "UploadFiles");
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                   
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        
                    }
                    repository.UploadExcel(fullPath);
                    return Ok("Upload successful");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }






    }
}
