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
    public class SingleItemSearchController : ControllerBase
    {
        [HttpGet]
        public string Get(string keyword)
        {
            try
            {
                var amazonUrl = "https://www.amazon.com/s?k=";
                var targetUrl = "https://www.target.com/s?searchTerm=";
                return amazonUrl + keyword;
                //return "Successful connect to Grocer Link";
            }
            catch
            {
                return "No";
            }
        }
    }
}
