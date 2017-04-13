using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class Occupation
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long WorkspaceId { get; set; }
        [Required]
        public NotificationType Type { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
