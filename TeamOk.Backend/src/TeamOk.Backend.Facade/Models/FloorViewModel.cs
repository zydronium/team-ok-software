using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class FloorViewModel
    {
        public long Id { get; set; }
        public long LocationId { get; set; }
        public LocationViewModel Location { get; set; }
        public string Name { get; set; }
        public int AmountWorkspaces { get; set; }
        public int AmountOcupiedWorkspaces { get; set; }
        public List<FacilityViewModel> Facilities { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
