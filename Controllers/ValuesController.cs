using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        SpecificationdbContext _DbContext;

        public ValuesController(SpecificationdbContext DbContext)
        {
            _DbContext = DbContext;
        }
        [HttpGet]
        public IActionResult GetSpec()
        {
            return Ok(_DbContext.SpecificationTables.ToList());
        }
    }
}
