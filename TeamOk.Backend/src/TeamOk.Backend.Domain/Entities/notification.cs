using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class Notification
    {
        [Required]
        public long ID { get; set; }
        [Required]
        public long WorkspaceID { get; set; }
        [Required]
        public NotificationType Type { get; set; }
        [Required]
        public DateTime TimestampFrom { get; set; }
        [Required]
        public DateTime TimestampTo { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
