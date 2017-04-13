using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class WorkspaceFacility
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long FacilityId { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
