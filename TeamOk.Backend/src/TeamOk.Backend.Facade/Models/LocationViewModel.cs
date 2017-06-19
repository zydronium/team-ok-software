using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class LocationViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }
        public string OpeningHours { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<FacilityViewModel> Facilities { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
