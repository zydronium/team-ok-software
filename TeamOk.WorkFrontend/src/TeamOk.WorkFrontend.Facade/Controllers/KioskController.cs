﻿using System;
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
