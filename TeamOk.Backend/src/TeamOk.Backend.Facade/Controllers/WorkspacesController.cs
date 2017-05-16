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
        [HttpGet("all")]
        public IEnumerable<WorkspaceViewModel> GetAllFreeWorkspaces()
        {
            var result = _context.Workspaces
                .Include(x => x.WorkspaceFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Include(x => x.Floor)
                .ThenInclude(x => x.Location)
                .Where(x => x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<WorkspaceViewModel> value = new List<WorkspaceViewModel>();
            foreach (var workspace in result)
            {
                WorkspaceViewModel localValue = new WorkspaceViewModel();
                localValue.Created = workspace.Created;
                localValue.FloorId = workspace.FloorID;
                localValue.Id = workspace.ID;
                localValue.Claimed = workspace.Claimed;
                localValue.ClaimedUntill = workspace.ClaimedUntill;
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

                localValue.Floor = new FloorViewModel();
                localValue.Floor.Created = workspace.Floor.Created;
                localValue.Floor.LocationId = workspace.Floor.LocationID;
                localValue.Floor.Id = workspace.Floor.ID;
                localValue.Floor.Modified = workspace.Floor.Modified;
                localValue.Floor.Name = workspace.Floor.Name;

                localValue.Floor.Location = new LocationViewModel();
                localValue.Floor.Location.Address = workspace.Floor.Location.Address;
                localValue.Floor.Location.City = workspace.Floor.Location.City;
                localValue.Floor.Location.Created = workspace.Floor.Location.Created;
                localValue.Floor.Location.Id = workspace.Floor.Location.ID;
                localValue.Floor.Location.Latitude = workspace.Floor.Location.Latitude;
                localValue.Floor.Location.Longitude = workspace.Floor.Location.Longitude;
                localValue.Floor.Location.Modified = workspace.Floor.Location.Modified;
                localValue.Floor.Location.Name = workspace.Floor.Location.Name;
                localValue.Floor.Location.OpeningHours = workspace.Floor.Location.OpeningHours;
                localValue.Floor.Location.Phonenumber = workspace.Floor.Location.Phonenumber;
                localValue.Floor.Location.Postcode = workspace.Floor.Location.Postcode;

                value.Add(localValue);
            }
            return value;
        }

        // GET: api/values
        [HttpGet("{FloorId}")]
        public IEnumerable<WorkspaceViewModel> GetWorkspaces(long FloorId)
        {
            var result = _context.Workspaces
                .Include(x => x.WorkspaceFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Include(x => x.Floor)
                .ThenInclude(x => x.Location)
                .Where(x => x.FloorID == FloorId && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<WorkspaceViewModel> value = new List<WorkspaceViewModel>();
            foreach (var workspace in result)
            {
                WorkspaceViewModel localValue = new WorkspaceViewModel();
                localValue.Created = workspace.Created;
                localValue.FloorId = workspace.FloorID;
                localValue.Id = workspace.ID;
                localValue.Claimed = workspace.Claimed;
                localValue.ClaimedUntill = workspace.ClaimedUntill;
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

                localValue.Floor = new FloorViewModel();
                localValue.Floor.Created = workspace.Floor.Created;
                localValue.Floor.LocationId = workspace.Floor.LocationID;
                localValue.Floor.Id = workspace.Floor.ID;
                localValue.Floor.Modified = workspace.Floor.Modified;
                localValue.Floor.Name = workspace.Floor.Name;

                localValue.Floor.Location = new LocationViewModel();
                localValue.Floor.Location.Address = workspace.Floor.Location.Address;
                localValue.Floor.Location.City = workspace.Floor.Location.City;
                localValue.Floor.Location.Created = workspace.Floor.Location.Created;
                localValue.Floor.Location.Id = workspace.Floor.Location.ID;
                localValue.Floor.Location.Latitude = workspace.Floor.Location.Latitude;
                localValue.Floor.Location.Longitude = workspace.Floor.Location.Longitude;
                localValue.Floor.Location.Modified = workspace.Floor.Location.Modified;
                localValue.Floor.Location.Name = workspace.Floor.Location.Name;
                localValue.Floor.Location.OpeningHours = workspace.Floor.Location.OpeningHours;
                localValue.Floor.Location.Phonenumber = workspace.Floor.Location.Phonenumber;
                localValue.Floor.Location.Postcode = workspace.Floor.Location.Postcode;

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
                .Include(x => x.Floor)
                .ThenInclude(x => x.Location)
                .OrderBy(x => x.Name)
                .Where(x => x.FloorID == FloorId && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .SingleOrDefault(x => x.ID == id);
            WorkspaceViewModel localValue = new WorkspaceViewModel();
            localValue.Created = workspace.Created;
            localValue.FloorId = workspace.FloorID;
            localValue.Id = workspace.ID;
            localValue.Claimed = workspace.Claimed;
            localValue.ClaimedUntill = workspace.ClaimedUntill;
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

            localValue.Floor = new FloorViewModel();
            localValue.Floor.Created = workspace.Floor.Created;
            localValue.Floor.LocationId = workspace.Floor.LocationID;
            localValue.Floor.Id = workspace.Floor.ID;
            localValue.Floor.Modified = workspace.Floor.Modified;
            localValue.Floor.Name = workspace.Floor.Name;

            localValue.Floor.Location = new LocationViewModel();
            localValue.Floor.Location.Address = workspace.Floor.Location.Address;
            localValue.Floor.Location.City = workspace.Floor.Location.City;
            localValue.Floor.Location.Created = workspace.Floor.Location.Created;
            localValue.Floor.Location.Id = workspace.Floor.Location.ID;
            localValue.Floor.Location.Latitude = workspace.Floor.Location.Latitude;
            localValue.Floor.Location.Longitude = workspace.Floor.Location.Longitude;
            localValue.Floor.Location.Modified = workspace.Floor.Location.Modified;
            localValue.Floor.Location.Name = workspace.Floor.Location.Name;
            localValue.Floor.Location.OpeningHours = workspace.Floor.Location.OpeningHours;
            localValue.Floor.Location.Phonenumber = workspace.Floor.Location.Phonenumber;
            localValue.Floor.Location.Postcode = workspace.Floor.Location.Postcode;

            return localValue;
        }
    }
}
