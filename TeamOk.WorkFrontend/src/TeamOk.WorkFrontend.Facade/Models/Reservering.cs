using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.WorkFrontend.Facade.Models
{
    public class Reservering
    {
        public DateTime claimedUntil { get; set; }

        public Reservering()
        {
            claimedUntil = DateTime.Now;
        }   

        //public bool setClaimedUntil()
    }
}
