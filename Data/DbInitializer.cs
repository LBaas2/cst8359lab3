using Lab3.Models;

namespace Lab3.Data
{
    public class DbInitializer
    {
        public static void Initialize(RsvpDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Rsvps.Any())
            {
                return;
            }

            var Rsvps = new Rsvp[] {
                new Rsvp {FullName = "Joe Smith", NeedsAccommodation = false, WorkshopTittle = "Tool workshop" },
                new Rsvp {FullName = "Bob Jones", NeedsAccommodation = true, WorkshopTittle = "Cooking workshop" }
            };
            foreach (Rsvp s in Rsvps) 
            {
                context.Add(s);
            }
            context.SaveChanges();
        }
    }
}
