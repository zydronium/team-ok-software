using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.WorkFrontend.Facade.Models;
using TeamOk.WorkFrontend.Facade;
using Microsoft.AspNetCore.Http;

namespace TeamOk.WorkFrontend.Facade.Controllers
{
    public class KioskController : Controller
    {

        private readonly IWerkplekkenBackend _context;

        public KioskController(IWerkplekkenBackend context)
        {
            _context = context;
        }

        public IActionResult Index([FromHeader]string macaddress, [FromQuery] string MAC)
        {
            Console.Write("Hello Index");
            var Bezet = getIsBezet(MAC);
            Console.Write(MAC);
            var test = _context.ApiWorkspaceunitsByMacAddressGet("test");
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
            return false;
        }

        [HttpPost]
        public void reserveerWerkplek(object sender, EventArgs e, [FromQuery] String MacAddress)
        {
            if (!getIsBezet(MacAddress))
            {
                int Minutes = Convert.ToInt32(Request.Cookies["ChosenMinutes"]);
                int Hours = Convert.ToInt32(Request.Cookies["ChosenHours"]);
                Status status = new Status();
                status.ClaimedUntill = DateTime.Now.AddMinutes(Minutes).AddHours(Hours);
                status.Claimed = true;
                _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
            }
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
        public ActionResult ChooseTime(ChosenTimeModel model, [FromQuery] String MacAddress)
        {
            int hours = model.Hours;
            int minutes = model.Minutes;
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(10);
            string s = model.ToString();
            Response.Cookies.Append("ChosenMinutes", hours.ToString(), options);
            Response.Cookies.Append("ChosenHours", minutes.ToString(), options);

            if (getIsBezet(MacAddress))
            {
                return View("Bezet");
            }
            else return View("Vrij");
        }

    }
}
