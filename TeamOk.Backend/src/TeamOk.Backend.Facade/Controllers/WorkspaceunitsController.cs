using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.Backend.Facade.Models;
using TeamOk.Backend.Domain.DAL;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamOk.Backend.Facade.Controllers
{
    [Route("api/[controller]")]
    public class WorkspaceunitsController : Controller
    {
        private readonly BackendDBContext _context;
        public WorkspaceunitsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET api/values/5
        [HttpGet("{MacAddress}")]
        public StatusViewModel GetStatusByMacAddress(string MacAddress)
        {
            var workspace = _context.Workspaces
                .Where(x=> x.Deleted == false)
                .SingleOrDefault(x => x.MacAddress == MacAddress);

            if(workspace == null)
            {
                return null;
            }

            if(workspace.Claimed)
            {
                if(workspace.ClaimedUntill < DateTime.Now)
                {
                    workspace.Claimed = false;
                    workspace.ClaimedUntill = DateTime.Now;
                    _context.SaveChanges();
                }
            }

            StatusViewModel localValue = new StatusViewModel();
            localValue.Claimed = workspace.Claimed;
            localValue.ClaimedUntill = workspace.ClaimedUntill;

            return localValue;
        }

        // PUT api/values/5
        [HttpPost("{MacAddress}")]
        public StatusViewModel PostStatusByMacAddress(string MacAddress, [FromBody]StatusViewModel value)
        {
            var workspace = _context.Workspaces
                .Where(x => x.Deleted == false)
                .SingleOrDefault(x => x.MacAddress == MacAddress);

            if (workspace == null)
            {
                return null;
            }

            if (workspace != null)
            {
                if(value.Claimed)
                {
                    workspace.Claimed = true;
                    workspace.ClaimedUntill = value.ClaimedUntill;
                }
                else
                {
                    workspace.Claimed = false;
                    workspace.ClaimedUntill = DateTime.Now;
                }
                _context.SaveChanges();
            }

            return GetStatusByMacAddress(MacAddress);
        }
    }
}
