using ClinicWebForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicWebForm.DBContext
{
    public class HealthContext : DbContext
    {
        public DbSet<Health> Health { get; set; }
        public DbSet<Visit> Visits { get; set; }

        //public HealthContext() : base("")
        //{

        //}
    }
}