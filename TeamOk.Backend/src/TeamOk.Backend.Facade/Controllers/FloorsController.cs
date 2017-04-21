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
    public class FloorsController : Controller
    {
        private readonly BackendDBContext _context;
        public FloorsController(BackendDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet("{LocationId}")]
        public IEnumerable<FloorViewModel> Get(long LocationId)
        {
            return new FloorViewModel[] { new FloorViewModel(), new FloorViewModel() };
        }

        // GET api/values/5
        [HttpGet("{LocationId}/{id}")]
        public FloorViewModel Get(long LocationId, long id)
        {
            return new FloorViewModel();
        }

        // POST api/values
        [HttpPost("{LocationId}")]
        public void Post(long LocationId, [FromBody]FloorViewModel value)
        {
        }

        // PUT api/values/5
        [HttpPut("{LocationId}/{id}")]
        public void Put(long LocationId, long id, [FromBody]FloorViewModel value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{LocationId}/{id}")]
        public void Delete(long LocationId, long id)
        {
        }
    }
}
