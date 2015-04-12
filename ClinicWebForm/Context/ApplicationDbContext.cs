using ClinicWebForm.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Health> Health { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Clinic> Clinics { get; set; }

#if DEBUG
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
#else
         public ApplicationDbContext()
            : base("healthConnStr", throwIfV1Schema: false)
        {
        }
#endif

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}