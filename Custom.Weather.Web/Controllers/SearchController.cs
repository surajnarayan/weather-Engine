using System;
using System.Collections.Generic;
using System.Linq;
using Custom.Weather.Contracts.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Custom.Weather.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Custom.Weather.Web.Controllers
{
    [Route("api/search")]
    public class SearchController : Controller
    {
        private IWeatherSearchService 

        [HttpPost]
        public async  Task<IActionResult> Search([FromBody]SearchRequest searchRequest)
        {

           
        }

    }
}
