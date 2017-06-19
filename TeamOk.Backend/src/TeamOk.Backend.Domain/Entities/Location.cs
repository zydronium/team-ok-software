using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class Location
    {
        [Required]
        public long ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Required]
        public string OpeningHours { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public List<LocationFacility> LocationFacilities { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
