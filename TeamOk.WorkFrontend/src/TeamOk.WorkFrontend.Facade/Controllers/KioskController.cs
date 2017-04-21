using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.WorkFrontend.Facade.Models;
using TeamOk.WorkFrontend.Facade;

namespace TeamOk.WorkFrontend.Facade.Controllers
{
    public class KioskController : Controller
    {

        private readonly IWerkplekkenBackend _context;

        public KioskController(IWerkplekkenBackend context)
        {
            _context = context;
        }

        public IActionResult Index([FromQuery] string MacAddress)
        {
            if (getIsBezet(MacAddress) == true)
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
            Status getStatus;
            try
            {
                getStatus = _context.ApiWorkspaceunitsByMacAddressGet(mac);
                bool isClaimed = (bool)getStatus.Claimed;
                return isClaimed;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return false;
        }

        [HttpPost]
        public void reserveerWerkplek(object sender, EventArgs e)
        {
            Console.Write("Hi");
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
        public ActionResult ChooseTime(ChosenTimeModel model, [FromQuery] string MacAddress)
        {
            int hours = model.Hours;
            int minutes = model.Minutes;
            if (getIsBezet(MacAddress))
            {
                return View("Bezet");
            }
            else return View("Vrij");
        }

    }
}
