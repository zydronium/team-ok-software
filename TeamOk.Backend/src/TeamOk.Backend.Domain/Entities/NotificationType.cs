using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Domain.Entities
{
    public class NotificationType
    {
        [required]
        public long Id { get; set; }
        [required]
        public string Name { get; set; }
    }
}
