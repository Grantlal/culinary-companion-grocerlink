using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrocerLink.LookupIngredients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GrocerLink.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrocerLinkController : ControllerBase
    {
        [HttpGet]
        public string Get(string keyword)
        {
            try
            {
                var ingredients = new List<string>();
                ingredients.Add(keyword);

                var ingredientSearch = new LookupIngredient();
                var cartResponse = ingredientSearch.lookUp(keyword);
                return cartResponse;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}
