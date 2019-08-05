using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.DBContexts
{
    public class AppUserDbContext : IdentityDbContext<AppUser>
    {
        public AppUserDbContext(DbContextOptions<AppUserDbContext> options) : base(options)
        {

        }


        //Says basically use everything from default identityuserdb and also add on what is in this method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>(user => user.HasIndex(x => x.ULocation).IsUnique(false));

            builder.Entity<Company>(com =>
            {
                com.ToTable("Companies");
                com.HasKey(x => x.Id);

                com.HasMany<AppUser>().WithOne().HasForeignKey(x => x.CId).IsRequired(false);
            });
        }

    }
}
