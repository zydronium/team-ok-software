using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.Backend.Facade.Models;
using TeamOk.Backend.Domain.DAL;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamOk.Backend.Facade.Controllers
{
    [Route("api/[controller]")]
    public class NotificationsController : Controller
    {
        private readonly BackendDBContext _context;
        public NotificationsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet("{WorkSpaceId}/{Claimed}")]
        public void ProcessNotification(long WorkSpaceId, Boolean Claimed)
        {

        }
    }
}
