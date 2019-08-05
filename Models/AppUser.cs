using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public class AppUser : IdentityUser
    {
        public string ULocation { get; set; } = "13 Celsius";

        public string CId { get; set; }
    }

    public class Company
    {
        public string Id { get; set; }
        public string CName { get; set; }
    }
}
