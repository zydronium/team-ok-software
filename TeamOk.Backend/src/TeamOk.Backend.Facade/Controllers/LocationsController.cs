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
    public class LocationsController : Controller
    {
        private readonly BackendDBContext _context;
        public LocationsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<LocationViewModel> GetLocations()
        {
            var result = _context.Locations
                .Include(x => x.LocationFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .Where(x => x.Deleted == false && x.LocationFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .OrderBy(x => x.Name)
                .ToList();

            List<LocationViewModel> value = new List<LocationViewModel>();
            foreach (var location in result)
            {
                LocationViewModel localValue = new LocationViewModel();
                localValue.Address = location.Address;
                localValue.City = location.City;
                localValue.Created = location.Created;
                localValue.Id = location.ID;
                localValue.Latitude = location.Latitude;
                localValue.Longitude = location.Longitude;
                localValue.Modified = location.Modified;
                localValue.Name = location.Name;
                localValue.OpeningHours = location.OpeningHours;
                localValue.Phonenumber = location.Phonenumber;
                localValue.Postcode = location.Postcode;
                localValue.Facilities = new List<FacilityViewModel>();

                foreach (var facilityInstance in location.LocationFacilities)
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
        
        // GET: api/Cursus
        [HttpGet("{id}")]
        public LocationViewModel GetLocationById([FromRoute] long id)
        {
            var location = _context.Locations
                .Include(x => x.LocationFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .OrderBy(x => x.Name)
                .Where(x => x.Deleted == false && x.LocationFacilities.Any(y => y.Deleted == false && y.FacilityInstance.Deleted == false))
                .SingleOrDefault(x => x.ID == id);
            LocationViewModel localValue = new LocationViewModel();
            localValue.Address = location.Address;
            localValue.City = location.City;
            localValue.Created = location.Created;
            localValue.Id = location.ID;
            localValue.Latitude = location.Latitude;
            localValue.Longitude = location.Longitude;
            localValue.Modified = location.Modified;
            localValue.Name = location.Name;
            localValue.OpeningHours = location.OpeningHours;
            localValue.Phonenumber = location.Phonenumber;
            localValue.Postcode = location.Postcode;
            localValue.Facilities = new List<FacilityViewModel>();

            foreach(var facilityInstance in location.LocationFacilities)
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
