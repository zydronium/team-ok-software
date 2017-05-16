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
    public class FloorsController : Controller
    {
        private readonly BackendDBContext _context;
        public FloorsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet("{LocationId}")]
        public IEnumerable<FloorViewModel> GetFloors(long LocationId)
        {
            var result = _context.Floors
                .Include(x => x.FloorFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Include(x => x.Location)
                .Where(x => x.LocationID == LocationId && x.Deleted == false && x.FloorFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<FloorViewModel> value = new List<FloorViewModel>();
            foreach (var floor in result)
            {
                FloorViewModel localValue = new FloorViewModel();
                localValue.Created = floor.Created;
                localValue.LocationId = floor.LocationID;
                localValue.Id = floor.ID;
                localValue.Modified = floor.Modified;
                localValue.Name = floor.Name;
                localValue.Facilities = new List<FacilityViewModel>();

                foreach (var facilityInstance in floor.FloorFacilities)
                {
                    FacilityViewModel localFacility = new FacilityViewModel();
                    localFacility.Created = facilityInstance.Created;
                    localFacility.Id = facilityInstance.ID;
                    localFacility.Modified = facilityInstance.Modified;
                    localFacility.Name = facilityInstance.FacilityInstance.Name;
                    localFacility.Value = facilityInstance.Value;

                    localValue.Facilities.Add(localFacility);
                }

                localValue.Location = new LocationViewModel();
                localValue.Location.Address = floor.Location.Address;
                localValue.Location.City = floor.Location.City;
                localValue.Location.Created = floor.Location.Created;
                localValue.Location.Id = floor.Location.ID;
                localValue.Location.Latitude = floor.Location.Latitude;
                localValue.Location.Longitude = floor.Location.Longitude;
                localValue.Location.Modified = floor.Location.Modified;
                localValue.Location.Name = floor.Location.Name;
                localValue.Location.OpeningHours = floor.Location.OpeningHours;
                localValue.Location.Phonenumber = floor.Location.Phonenumber;
                localValue.Location.Postcode = floor.Location.Postcode;

                var WorkspaceAmountresult = _context.Workspaces
                    .Include(x => x.WorkspaceFacilities)
                    .ThenInclude(x => x.FacilityInstance)
                    .Include(x => x.Floor)
                    .ThenInclude(x => x.Location)
                    .Where(x => x.FloorID == floor.ID && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                    .OrderBy(x => x.Name)
                    .ToList();
                
                int AmountWorkspaces = 0;
                int AmountClaimedWorkspaces = 0;

                foreach (var workspace in WorkspaceAmountresult)
                {
                    AmountWorkspaces++;
                    if (workspace.Claimed)
                    {
                        AmountClaimedWorkspaces++;
                    }
                }

                localValue.AmountWorkspaces = AmountWorkspaces;
                localValue.AmountWorkspaces = AmountClaimedWorkspaces;

                value.Add(localValue);
            }
            return value;
        }

        // GET api/values/5
        [HttpGet("{LocationId}/{id}")]
        public FloorViewModel GetFloorById(long LocationId, long id)
        {
            var floor = _context.Floors
                .Include(x => x.FloorFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Include(x => x.Location)
                .OrderBy(x => x.Name)
                .Where(x => x.LocationID == LocationId && x.Deleted == false && x.FloorFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .SingleOrDefault(x => x.ID == id);
            FloorViewModel localValue = new FloorViewModel();
            localValue.Created = floor.Created;
            localValue.LocationId = floor.LocationID;
            localValue.Id = floor.ID;
            localValue.Modified = floor.Modified;
            localValue.Name = floor.Name;
            localValue.Facilities = new List<FacilityViewModel>();

            foreach (var facilityInstance in floor.FloorFacilities)
            {
                FacilityViewModel localFacility = new FacilityViewModel();
                localFacility.Created = facilityInstance.Created;
                localFacility.Id = facilityInstance.ID;
                localFacility.Modified = facilityInstance.Modified;
                localFacility.Name = facilityInstance.FacilityInstance.Name;
                localFacility.Value = facilityInstance.Value;

                localValue.Facilities.Add(localFacility);
            }

            localValue.Location = new LocationViewModel();
            localValue.Location.Address = floor.Location.Address;
            localValue.Location.City = floor.Location.City;
            localValue.Location.Created = floor.Location.Created;
            localValue.Location.Id = floor.Location.ID;
            localValue.Location.Latitude = floor.Location.Latitude;
            localValue.Location.Longitude = floor.Location.Longitude;
            localValue.Location.Modified = floor.Location.Modified;
            localValue.Location.Name = floor.Location.Name;
            localValue.Location.OpeningHours = floor.Location.OpeningHours;
            localValue.Location.Phonenumber = floor.Location.Phonenumber;
            localValue.Location.Postcode = floor.Location.Postcode;

            var WorkspaceAmountresult = _context.Workspaces
                .Include(x => x.WorkspaceFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Include(x => x.Floor)
                .ThenInclude(x => x.Location)
                .Where(x => x.FloorID == floor.ID && x.Deleted == false && x.WorkspaceFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            int AmountWorkspaces = 0;
            int AmountClaimedWorkspaces = 0;

            foreach(var workspace in WorkspaceAmountresult)
            {
                AmountWorkspaces++;
                if(workspace.Claimed)
                {
                    AmountClaimedWorkspaces++;
                }
            }

            localValue.AmountWorkspaces = AmountWorkspaces;
            localValue.AmountWorkspaces = AmountClaimedWorkspaces;

            return localValue;
        }
    }
}
