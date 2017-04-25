using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class LocationFacility
    {
        [Required]
        public long ID { get; set; }
        [Required]
        public long FacilityID { get; set; }
        [Required]
        public Facility FacilityInstance { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
