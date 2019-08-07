using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public class AppUser : IdentityUser
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal UserPayRate { get; set; }


        public ICollection<TimeCard> TimeCards { get; set; }
    }
}