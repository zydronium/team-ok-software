using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.WorkFrontend.Facade.Models;
using TeamOk.WorkFrontend.Facade;
using Microsoft.AspNetCore.Http;
using TeamOk.WorkFrontend.Facade.Generated.Models;

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
            if (MacAddress != null)
            {
                HttpContext.Session.SetString("MacAddress", MacAddress);
            }
            if (HttpContext.Session.GetString("MacAddress") != null) {
                if (getIsBezet(MacAddress) == true)
                {
                    return View("Bezet");
                }
                else
                {
                    return View("Vrij");
                }
            }
            return View("Error");
        }

                 
        private bool getIsBezet(string mac)
        {
            StatusViewModel Status;
            try
            {
                Status = _context.ApiWorkspaceunitsByMacAddressGet(mac);
                bool isClaimed = (bool)Status.Claimed;
                return isClaimed;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

   
        public IActionResult geefWerkplekVrij()
        {
            var MacAddress = HttpContext.Session.GetString("MacAddress");
            StatusViewModel modelToPost = new StatusViewModel();
            StatusViewModel postedModel = new StatusViewModel();
            if (!getIsBezet(MacAddress))
            {
                    StatusViewModel status = new StatusViewModel();
                    status.ClaimedUntill = DateTime.Now;
                    status.Claimed = false;
                    modelToPost = status;
                    postedModel = _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
            }
            return Index(null);
        }

        
        public IActionResult reserveerWerkplek()
        {
            var MacAddress = HttpContext.Session.GetString("MacAddress");
            StatusViewModel modelToPost = new StatusViewModel();
            StatusViewModel postedModel =  new StatusViewModel();
            if (!getIsBezet(MacAddress))
            {
                double? Minutes = Convert.ToDouble(Request.Cookies["ChosenMinutes"]);
                double? Hours = Convert.ToDouble(Request.Cookies["ChosenHours"]);
                if (Minutes != 0 && Hours != 0)
                {
                    StatusViewModel status = new StatusViewModel();
                    status.ClaimedUntill = DateTime.Now.AddMinutes((double) Minutes).AddHours((double) Hours);
                    status.Claimed = true;
                    modelToPost = status;
                    postedModel = _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
                }
                else
                {
                    StatusViewModel status = new StatusViewModel();
                    status.ClaimedUntill = DateTime.Now.AddMinutes(30).AddHours(0);
                    status.Claimed = true;
                    modelToPost = status;
                    postedModel = _context.ApiWorkspaceunitsByMacAddressPost(MacAddress, status);
                }
                HttpContext.Session.SetString("ClaimedUntill", modelToPost.ClaimedUntill.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            ViewData["time"] = HttpContext.Session.GetString("ClaimedUntill");

            return Index(null);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Voor meer info";
            ViewData["URL"] = "goo.gl/jOHd8R";
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

        public IActionResult ChooseTime(ChosenTimeModel model)
        {
            var MacAddress = HttpContext.Session.GetString("MacAddress");
            int hours = model.Hours;
            int minutes = model.Minutes;
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(10);
            string s = model.ToString();
            Response.Cookies.Append("ChosenMinutes", hours.ToString(), options);
            Response.Cookies.Append("ChosenHours", minutes.ToString(), options);

            return Index(null);
        }

    }
}
