using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GrocerLink.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrocerLinkController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            try
            {
                return "Successful connect to Grocer Link";
            }
            catch
            {
                return "No";
            }
        }
    }
}
