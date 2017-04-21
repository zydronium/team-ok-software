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
        public IEnumerable<Location> GetLocations()
        {
            var result = _context.Locations
                .Include(x => x.LocationFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .OrderBy(x => x.Name)
                .ToList();

            List<Location> value = new List<Location>();
            foreach (var location in result)
            {
                Location localValue = new Location();
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



                value.Add(localValue);
            }
            return value;
        }
        
        // GET: api/Cursus
        [HttpGet("{id}")]
        public Location GetLocation([FromRoute] long id)
        {
            var location = _context.Locations
                .Include(x => x.LocationFacilities)
                .ThenInclude(x => x.FacilityInstance)
                .OrderBy(x => x.Name)
                .SingleOrDefault(x => x.ID == id);
            Location localValue = new Location();
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



            return localValue;
        }
    }
}
