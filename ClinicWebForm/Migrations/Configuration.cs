namespace ClinicWebForm.Migrations
{
    using ClinicWebForm.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClinicWebForm.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ClinicWebForm.Context.ApplicationDbContext";
        }

        protected override void Seed(ClinicWebForm.Context.ApplicationDbContext context)
        {
            //Seed Forms
            context.Forms.AddOrUpdate(
                new Form { FormName = "Household Registration", Active = true },
                new Form { FormName = "Individual Adult Health Record", Active = true },
                new Form { FormName = "Maternal and Child Health Record", Active = true },
                new Form { FormName = "Outreach Team Monthly Summary", Active = true },
                new Form { FormName = "Referral", Active = true },
                new Form { FormName = "Visit Summary", Active = true }
                );
        }
    }
}
