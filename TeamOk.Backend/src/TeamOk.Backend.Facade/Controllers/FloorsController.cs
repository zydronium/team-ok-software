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
    public class FloorsController : Controller
    {
        // GET: api/values
        [HttpGet("{LocationId}")]
        public IEnumerable<Floor> Get(int LocationId)
        {
            return new Floor[] { new Floor(), new Floor() };
        }

        // GET api/values/5
        [HttpGet("{LocationId}/{id}")]
        public Floor Get(int LocationId, int id)
        {
            return new Floor();
        }

        // POST api/values
        [HttpPost("{LocationId}")]
        public void Post(int LocationId, [FromBody]Floor value)
        {
        }

        // PUT api/values/5
        [HttpPut("{LocationId}/{id}")]
        public void Put(int LocationId, int id, [FromBody]Floor value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{LocationId}/{id}")]
        public void Delete(int LocationId, int id)
        {
        }
    }
}
