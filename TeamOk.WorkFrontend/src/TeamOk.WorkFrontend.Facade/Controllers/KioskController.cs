using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamOk.WorkFrontend.Facade.Controllers
{
    public class KioskController : Controller
    {
        public IActionResult Index()
        {
            //Vraag de backend wat de status is van deze tafel 

            //If tafel = bezet
            //return View("Bezet");
            

            //If tafel != bezet
            //Return View("Vrij")


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
