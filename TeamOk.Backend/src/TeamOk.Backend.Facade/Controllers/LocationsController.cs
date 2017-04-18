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
    public class LocationsController : Controller
    {
        private readonly BackendDBContext _context;
        public LocationsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return new Location[] { new Location(), new Location() };
        }

        public IEnumerable<Location> GetLocations()
        {
            var result = _context.Locations
                .OrderBy(x => x.Name)
                .ToList();
            return result;
        }
        
        // GET: api/Cursus
        [HttpGet("{id}")]
        public Location GetLocation([FromRoute] long id)
        {
            var result = _context.Locations
                .OrderBy(x => x.Name)
                .SingleOrDefault(x => x.ID == id);
            return result;
        }
    }
}
