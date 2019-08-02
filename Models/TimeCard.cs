using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public class TimeCard
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public decimal ClockInHour { get; set; }
        public decimal ClockInMinute { get; set; }
        public decimal PayRate { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalHour { get; set; }
        public decimal TotalMinute { get; set; }


    }
}
