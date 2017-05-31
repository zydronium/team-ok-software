using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.Backend.Facade.Models;
using TeamOk.Backend.Domain.DAL;
using TeamOk.Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
            string type = "";
            if (Claimed)
            {
                type = "Claimed";
            }
            else
            {
                type = "Free";
            }

            var Type = _context.NotificationType
                .Where(x => x.Deleted == false)
                .SingleOrDefault(x => x.Name == type);

            if (Type != null)
            {
                Notification notification = new Notification();
                notification.WorkspaceID = WorkSpaceId;
                notification.Type = Type;
                notification.TypeID = Type.ID;
                notification.Created = DateTime.Now;
                notification.Modified = DateTime.Now;
                notification.Deleted = false;
                _context.Notifications.Add(notification);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }

                var result = _context.Notifications
                    .Include(x => x.Type)
                    .Where(x => x.WorkspaceID == WorkSpaceId && x.Deleted == false && x.TypeID == Type.ID && x.Created > DateTime.Now.AddMinutes(-15))
                    .ToList();

                if (result.Count >= 3)
                {
                    var workspace = _context.Workspaces
                    .Where(x => x.Deleted == false)
                    .SingleOrDefault(x => x.ID == WorkSpaceId);

                    if (workspace != null)
                    {
                        if(Claimed)
                        {
                            workspace.Claimed = true;
                            workspace.ClaimedUntill = DateTime.Now.AddMinutes(30);
                        }
                        else
                        {
                            workspace.Claimed = false;
                            workspace.ClaimedUntill = DateTime.Now;
                        }
                        _context.SaveChanges();
                    }
                }
            }
        }
    }
}
