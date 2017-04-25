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
                .Where(x => x.LocationID == LocationId && x.Deleted == false && x.FloorFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<FloorViewModel> value = new List<FloorViewModel>();
            foreach (var floor in result)
            {
                FloorViewModel localValue = new FloorViewModel();
                localValue.Created = floor.Created;
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
                .OrderBy(x => x.Name)
                .Where(x => x.LocationID == LocationId && x.Deleted == false && x.FloorFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .SingleOrDefault(x => x.ID == id);
            FloorViewModel localValue = new FloorViewModel();
            localValue.Created = floor.Created;
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

            return localValue;
        }
    }
}
