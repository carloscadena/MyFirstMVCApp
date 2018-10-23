using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {
            // Looks for the Razor View Page located in
            // Views -> Home -> Index.cshtml
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(int startDate, int endDate)
        {
            // Redirect to another Action. 
            // we create a 
            return RedirectToAction("Result", new { startDate, endDate  });
        }

        public ViewResult Result(int startDate, int endDate)
        {
            List<Person> people = Person.GetPersons(startDate, endDate);
            return View(people);
        }
    }
}
