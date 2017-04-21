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
    public class WorkspacesController : Controller
    {
        private readonly BackendDBContext _context;
        public WorkspacesController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet("{FloorId}")]
        public IEnumerable<WorkspaceViewModel> Get(long FloorId)
        {
            return new WorkspaceViewModel[] { new WorkspaceViewModel(), new WorkspaceViewModel() };
        }

        // GET api/values/5
        [HttpGet("{FloorId}/{id}")]
        public WorkspaceViewModel Get(long FloorId, long id)
        {
            return new WorkspaceViewModel();
        }

        // POST api/values
        [HttpPost("{FloorId}")]
        public void Post(long FloorId, [FromBody]WorkspaceViewModel value)
        {
        }

        // PUT api/values/5
        [HttpPut("{FloorId}/{id}")]
        public void Put(long FloorId, long id, [FromBody]WorkspaceViewModel value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{FloorId}/{id}")]
        public void Delete(long FloorId, long id)
        {
        }
    }
}
