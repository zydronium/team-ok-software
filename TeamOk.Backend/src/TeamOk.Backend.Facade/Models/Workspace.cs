﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class Workspace
    {
        public long Id { get; set; }
        public long FloorId { get; set; }
        public string Name { get; set; }
        public bool Claimed { get; set; }
        public List<Facility> Facilities { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
