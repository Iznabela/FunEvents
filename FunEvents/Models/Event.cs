using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunEvents.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int OrganizerID { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int SpotsAvailable { get; set; }

        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }
    }
}
