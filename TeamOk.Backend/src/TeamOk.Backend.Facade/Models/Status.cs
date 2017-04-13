using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class Status
    {
        public ClaimType ClaimType { get; set; }
        public DateTime ClaimedUntill { get; set; }
    }
}
