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
           
            var Bezet = getIsBezet();

            //If tafel = bezet
            //return View("Bezet");
            //If tafel != bezet
            //Return View("Vrij")
            if (Bezet)
            {
                return View("Bezet");
            }
            else
            {
                return View("Vrij");
            }
        }

        private bool getIsBezet()
        {
            //Vraag de backend wat de status is van deze tafel 
            return true;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Voor meer info";
            ViewData["URL"] = "bit.ly/????";
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
