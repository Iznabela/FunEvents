using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunEvents.Data;
using FunEvents.Models;

namespace FunEvents.Data
{
    public static class DbIntializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // if database contains any events, return (already seeded)
            if (context.Events.Any())
            {
                return;
            }

            Attendee[] attendees = new Attendee[]
            {
                new Attendee{Name="Deg Degsson", Email="deg@deg.com", PhoneNumber=0746234411},
                new Attendee{Name="Sol Solström", Email="solen@gmail.com", PhoneNumber=0798446699},
                new Attendee{Name="Isabella Pettersson", Email="bells@gmail.com", PhoneNumber=0788332297},
                new Attendee{Name="Kalle Blomnell", Email="kalles@hotmail.com", PhoneNumber=0711223355},
                new Attendee{Name="Nora Lindström", Email="nuren@gmail.com", PhoneNumber=0788995642},
                new Attendee{Name="Ahmad Srahin", Email="ahmad@hotmail.com", PhoneNumber=0722511463}
            };

            context.Attendees.AddRange(attendees);
            context.SaveChanges();

            Organizer[] organizers = new Organizer[]
            {
                new Organizer{Name="Event makerz", Email="event.makerz@gmail.com", PhoneNumber=0788594655},
                new Organizer{Name="Team Shark", Email="shark.info@gmail.com", PhoneNumber=0744581613}
            };
            context.Organizers.AddRange(organizers);
            context.SaveChanges();

            Event[] events = new Event[]
            {
                new Event{Title="Food Festival", OrganizerID=2, Description="All you can eat - food from all around the world - all you need is a ticket!", Place="On the street", Address="Gourmet Lane 63", Date= new DateTime(2021,7,21), SpotsAvailable=1000},
                new Event{Title="Free Karaoke night", OrganizerID=2, Description="Join this event to be a part of a fantastic karaoke night!", Place="Sing Along", Address="Vocals street 2", Date= new DateTime(2021,5,13), SpotsAvailable=35 },
                new Event{Title="Run for fun", OrganizerID=1, Description="A race with no competition, just for fun! Get amazing treats on the way!", Place="In the woods", Address="Green forest 23", Date= new DateTime(2021,6,5), SpotsAvailable=500 },
                new Event{Title="Poetry slam", OrganizerID=1, Description="Got a poem? Wanna perform? Join this event to enter the competition, or be the audience!", Place="The Green Lion", Address="Lonely road 4", Date= new DateTime(2021,4,30), SpotsAvailable=65 },
                new Event{Title="Finger Painting", OrganizerID=1, Description="Bring your inner child and join this event to get creative!", Place="Art factory", Address="Artsy road 31", Date= new DateTime(2021,10,11), SpotsAvailable=30 },
                new Event{Title="Splash away", OrganizerID=2, Description="Exclusive offer for the Shark Water Park premiere! 2 for 1 entrance", Place="Shark Water park", Address="Ocean lane 11", Date= new DateTime(2021,5,21), SpotsAvailable=650 }
            };

            context.Events.AddRange(events);
            context.SaveChanges();            
        }
    }
}
