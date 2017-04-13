using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.Backend.Facade.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamOk.Backend.Facade.Controllers
{
    [Route("api/[controller]")]
    public class WorkspaceunitsController : Controller
    {
        // GET api/values/5
        /// <remarks>
        /// ClaimType is a enum {Claim, Free}
        /// 
        /// </remarks>
        [HttpGet("{MacAddress}")]
        public Status Get(string MacAddress)
        {
            return new Status();
        }

        // PUT api/values/5
        /// <remarks>
        /// ClaimType is a enum {Claim, Free}
        /// 
        /// </remarks>
        [HttpPost("{MacAddress}")]
        public void Put(string MacAddress, [FromBody]Status value)
        {
        }
    }
}
