using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Github_Demo___GHU.Controllers
{
    public class ProductsController : Controller
    {
        // This is just to show pull requests
        public IActionResult Index()
        {
            return View();
        }
    }
}