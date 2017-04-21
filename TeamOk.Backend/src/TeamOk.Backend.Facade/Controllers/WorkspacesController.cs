﻿using System;
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
        public IEnumerable<Workspace> Get(long FloorId)
        {
            return new Workspace[] { new Workspace(), new Workspace() };
        }

        // GET api/values/5
        [HttpGet("{FloorId}/{id}")]
        public Workspace Get(long FloorId, long id)
        {
            return new Workspace();
        }

        // POST api/values
        [HttpPost("{FloorId}")]
        public void Post(long FloorId, [FromBody]Workspace value)
        {
        }

        // PUT api/values/5
        [HttpPut("{FloorId}/{id}")]
        public void Put(long FloorId, long id, [FromBody]Workspace value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{FloorId}/{id}")]
        public void Delete(long FloorId, long id)
        {
        }
    }
}
