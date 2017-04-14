using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamOk.WorkFrontend.Facade.Models
{
    public class Reservering
    {
        public DateTime claimedUntil { get; set; }
        public bool Claimed { get; set; }

        public Reservering()
        {
            
        }   

        public void setClaimedUntil(ChosenTimeModel model)
        {
            claimedUntil = DateTime.Now;
            //Eventuele businessrules voor maximale reserveringstijd hier
            claimedUntil.AddHours(model.Hours);
            claimedUntil.AddMinutes(model.Minutes);
            Claimed = true;
        }
    }
}
