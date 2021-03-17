﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunEvents.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Event> Events { get; set; } 
    }
}