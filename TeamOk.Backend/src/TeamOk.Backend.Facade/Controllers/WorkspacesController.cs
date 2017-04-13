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
    public class WorkspacesController : Controller
    {
        // GET: api/values
        [HttpGet("{FloorId}")]
        public IEnumerable<Workspace> Get(int FloorId)
        {
            return new Workspace[] { new Workspace(), new Workspace() };
        }

        // GET api/values/5
        [HttpGet("{FloorId}/{id}")]
        public Workspace Get(int FloorId, int id)
        {
            return new Workspace();
        }

        // POST api/values
        [HttpPost("{FloorId}")]
        public void Post(int FloorId, [FromBody]Workspace value)
        {
        }

        // PUT api/values/5
        [HttpPut("{FloorId}/{id}")]
        public void Put(int FloorId, int id, [FromBody]Workspace value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{FloorId}/{id}")]
        public void Delete(int FloorId, int id)
        {
        }
    }
}
