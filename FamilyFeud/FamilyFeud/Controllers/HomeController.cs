using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FamilyFeud.Controllers
{
    public class HomeController : Controller
    {
        private string filePath = @"wwwroot\data.txt"; //@"C:\Users\aamathur\Desktop\clutter\livebrackets\data.txt";

        public IActionResult Index()
        {
            ViewData["DataTransfer"] = System.IO.File.ReadAllLines(filePath);
            return View();
        }

        [HttpPost]
        public IActionResult Index(string valueINeed)
        {
            System.IO.File.AppendAllText(filePath, valueINeed + "\n");
            ViewData["DataTransfer"] = System.IO.File.ReadAllLines(filePath);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
