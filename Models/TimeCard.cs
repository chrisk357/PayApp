using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public class TimeCard   
    {
        public int TimeCardID { get; set; }
        [Display(Name="Clock In Hours")]
        public int ClockInH { get; set; }
        [Display(Name ="Clock In Minutes")]
        public int ClockInM { get; set; }
        [Display(Name ="Clock Out Hours")]
        public int ClockOutH { get; set; }
        [Display(Name = "Clock Out Minutes")]
        public int ClockOutM { get; set; }
        [Display(Name ="Date")]
        public DateTimeOffset ShiftDate { get; set; }

        public AppUser AppUser { get; set; }
        public Location Location { get; set; }

    }
}
