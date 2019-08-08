using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public class TimeCard   
    {
        public int TimeCardID { get; set; }
        public int ClockInH { get; set; }
        public int ClockInM { get; set; }
        public int ClockOutH { get; set; }
        public int ClockOutM { get; set; }
        public DateTime ShiftDate { get; set; }

        public AppUser AppUser { get; set; }
        public Location Location { get; set; }

    }
}
