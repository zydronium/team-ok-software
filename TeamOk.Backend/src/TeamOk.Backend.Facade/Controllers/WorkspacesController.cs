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
    public class WorkspacesController : Controller
    {
        private readonly BackendDBContext _context;
        public WorkspacesController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet("{FloorId}")]
        public IEnumerable<WorkspaceViewModel> GetWorkspaces(long FloorId)
        {
            var result = _context.Workspaces
                .Include(x => x.WorkspaceFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Where(x => x.FloorID == FloorId && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<WorkspaceViewModel> value = new List<WorkspaceViewModel>();
            foreach (var workspace in result)
            {
                WorkspaceViewModel localValue = new WorkspaceViewModel();
                localValue.Created = workspace.Created;
                localValue.Id = workspace.ID;
                localValue.Modified = workspace.Modified;
                localValue.Name = workspace.Name;
                localValue.Claimed = false;
                localValue.Facilities = new List<FacilityViewModel>();

                foreach (var facilityInstance in workspace.WorkspaceFacilities)
                {
                    FacilityViewModel localFacility = new FacilityViewModel();
                    localFacility.Created = facilityInstance.Created;
                    localFacility.Id = facilityInstance.ID;
                    localFacility.Modified = facilityInstance.Modified;
                    localFacility.Name = facilityInstance.FacilityInstance.Name;
                    localFacility.Value = facilityInstance.Value;

                    localValue.Facilities.Add(localFacility);
                }

                value.Add(localValue);
            }
            return value;
        }

        // GET api/values/5
        [HttpGet("{FloorId}/{id}")]
        public WorkspaceViewModel GetWorkspaceById(long FloorId, long id)
        {
            var workspace = _context.Workspaces
                .Include(x => x.WorkspaceFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .OrderBy(x => x.Name)
                .Where(x => x.FloorID == FloorId && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .SingleOrDefault(x => x.ID == id);
            WorkspaceViewModel localValue = new WorkspaceViewModel();
            localValue.Created = workspace.Created;
            localValue.Id = workspace.ID;
            localValue.Modified = workspace.Modified;
            localValue.Name = workspace.Name;
            localValue.Facilities = new List<FacilityViewModel>();

            foreach (var facilityInstance in workspace.WorkspaceFacilities)
            {
                FacilityViewModel localFacility = new FacilityViewModel();
                localFacility.Created = facilityInstance.Created;
                localFacility.Id = facilityInstance.ID;
                localFacility.Modified = facilityInstance.Modified;
                localFacility.Name = facilityInstance.FacilityInstance.Name;
                localFacility.Value = facilityInstance.Value;

                localValue.Facilities.Add(localFacility);
            }

            return localValue;
        }
    }
}
