using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamOk.Backend.Facade.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamOk.Backend.Facade.Controllers
{
    [Route("api/[controller]")]
    public class LocationsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return new Location[] { new Location(), new Location() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Location Get(int id)
        {
            return new Location();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Location value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Location value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
