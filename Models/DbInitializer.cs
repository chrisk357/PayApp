using PayApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {

            if (!context.Locations.Any())
            {
                context.AddRange
                    (
                        new Location { LocationName = "13 Celsius"},
                        new Location { LocationName = "Public Services"}
                    );
            }

            if (!context.AppUsers.Any())
            {
                context.AddRange
                    (
                        new AppUser { LastName = "Kaye", FirstName = "Chris", UserPayRate = 14}
                    );
                context.SaveChanges();
            }



            if (!context.TimeCards.Any())
            {
                context.AddRange
                    (
                        new TimeCard { ClockInH = 17, ClockInM = 05, ClockOutH = 22, ClockOutM = 10, ShiftDate = new DateTime(8/7/2019) }
                    );
                context.SaveChanges();
            }
        }
    }
}
