using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class Facility
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
