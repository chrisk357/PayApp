using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public decimal ClockOutHour { get; set; }
        public decimal ClockOutMinute { get; set; }
        public decimal PayRate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public decimal TotalHour { get; set; }
        public decimal TotalMinute { get; set; }


    }
}
