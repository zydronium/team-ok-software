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
        public void reserveerWerkplek(object sender, EventArgs e, [FromQuery] String MacAddress)
        {
            if (!getIsBezet(MacAddress))
            {
                double? Minutes = Convert.ToDouble(Request.Cookies["ChosenMinutes"]);
                double? Hours = Convert.ToDouble(Request.Cookies["ChosenHours"]);
                if (Minutes != null && Hours != null)
                {
                    Status status = new Status();
                    status.ClaimedUntill = DateTime.Now.AddMinutes((double) Minutes).AddHours((double) Hours);
                    status.Claimed = true;
                    _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
                }
                else
                {
                    Status status = new Status();
                    status.ClaimedUntill = DateTime.Now.AddMinutes(30).AddHours(0);
                    status.Claimed = true;
                    _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
                }
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
