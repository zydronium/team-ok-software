﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamOk.Backend.Facade.Controllers
{
    [Route("api/[controller]")]
    public class NotificationsController : Controller
    {
        // POST api/values
        [HttpPost("{WorkSpaceId}")]
        public void Post(int WorkSpaceId, [FromBody]Notification value)
        {
        }
    }
}
