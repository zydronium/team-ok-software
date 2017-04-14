using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.WorkFrontend.Facade.Models;

namespace TeamOk.WorkFrontend.Facade.Controllers
{
    public class KioskController : Controller
    {
        public IActionResult Index([FromHeader]string macaddress, [FromQuery] string MAC)
        {
            Console.Write("Hello Index");
            var Bezet = getIsBezet(MAC);
            Console.Write(MAC);
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

        private bool getIsBezet(string mac)
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

        public IActionResult Timer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChooseTime(ChosenTimeModel model)
        {
            int hours = model.Hours;
            int minutes = model.Minutes;
            if (getIsBezet(""))
            {
                return View("Bezet");
            }
            else return View("Vrij");
        }

    }
}
