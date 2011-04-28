using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3CodeFirst.Domain
{
    public class RSVP
    {
        public int RsvpID { get; set; }
        public int DinnerID { get; set; }
        public string AttendeeEmail { get; set; }

        public virtual Dinner Dinnner { get; set; }
    }
}