using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var b = new List<Class>()
            {
                new Class() { BookID = 1, BookName = "Moby Dick", BookWriter = "Herman Menville"},
                new Class() { BookID = 2, BookName = "Black Beauty", BookWriter = "Anna Sewell" },
                new Class() { BookID = 3, BookName = "Le Petit Prince", BookWriter = "Antoine de Saint-Exupéry" }
            };
            return View(b);
        }
        
    }
}
