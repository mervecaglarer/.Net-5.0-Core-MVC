using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Index2() 
        {
            return View();
        }
        public int Index3()
        {
            return 23;
        }
    }
}
