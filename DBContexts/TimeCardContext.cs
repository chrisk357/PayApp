using Microsoft.EntityFrameworkCore;
using PayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.DBContexts
{
    public class TimeCardContext : DbContext
    {
        public TimeCardContext(DbContextOptions<TimeCardContext> options) : base(options)
        {
            
        }
        public DbSet <TimeCard>  TimeCards{ get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeCard>().HasData(
                new TimeCard
                {
                    Id = 1,
                    LocationName = "13 Celsius",
                    ClockInHour = 17,
                    ClockInMinute = 00,
                    ClockOutHour = 22,
                    ClockOutMinute = 05,
                    TotalHour = 5,
                    TotalMinute = 05,
                }
                );
        }
    }
}


