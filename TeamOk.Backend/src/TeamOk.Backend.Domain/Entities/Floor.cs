using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class Floor
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long LocationId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<FloorFacility> FloorFacilities { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
