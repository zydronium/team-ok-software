using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.Backend.Facade.Models
{
    public class Status
    {
        ClaimType claimType { get; set; }
        DateTime ClaimedUntill { get; set; }
    }
}
