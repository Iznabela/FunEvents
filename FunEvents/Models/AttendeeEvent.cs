using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunEvents.Models
{
    public class AttendeeEvent
    {
        public int ID { get; set; }
        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
