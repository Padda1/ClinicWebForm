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

#if DEBUG
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
#else
         public ApplicationDbContext() : base("healthConnStr", throwIfV1Schema: false)
        {
        }
#endif

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Health> Health { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Visit> Visits { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Clinic> Clinics { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Ward> Wards { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Questions> Questions { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Form> Forms { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.CHW> CHWs { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Province> Provinces { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Municipality> Municipalities { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.IndividualMember> IndividualMembers { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Household> Households { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.House> Houses { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.QuestionCategory> QuestionCategories { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.FormDocument> FormDocuments { get; set; }

        public System.Data.Entity.DbSet<ClinicWebForm.Models.Answer> Answers { get; set; }
    }
}