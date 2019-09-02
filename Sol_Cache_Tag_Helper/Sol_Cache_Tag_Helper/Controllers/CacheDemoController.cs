using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// https://www.davepaquette.com/archive/2015/06/03/mvc-6-cache-tag-helper.aspx
// https://codingblast.com/asp-net-core-mvc-caching-taghelpers/

namespace Sol_Cache_Tag_Helper.Controllers
{
    public class CacheDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        [HttpGet("varbyroute/{id:int}")]
        public IActionResult VarByRouteDemo()
        {
            return View();
        }

        [HttpPost("submit/{id:int}")]
        public IActionResult VarByDemo()
        {
            ViewBag.Id = id;
            return View();
        }
    }
}