using ClinicWebForm.Context;
using ClinicWebForm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ClinicWebForm.Utils
{
    public class AppUtils
    {
        public static string WordTemplateDirectory = HttpContext.Current.Server.MapPath("~/DocumentTemplates/");

        public static List<Clinic> LoadClinics()
        {
            var objClinics = new List<Clinic>();

            using (var dbContext = new ApplicationDbContext())
            {
                objClinics = dbContext.Clinics.Where(c => c.Active == true).ToList();
            }

            objClinics.Insert(0, new Clinic { Id = 0, ClinicDescription = "Select", Active = true });

            return objClinics;
        }

        public static List<Ward> LoadWards()
        {
            var objWards = new List<Ward>();

            using (var dbContext = new ApplicationDbContext())
            {
                objWards = dbContext.Wards.Where(c => c.Active == true).ToList();
            }

            objWards.Insert(0, new Ward { Id = 0, WardDescription = "Select", Active = true });

            return objWards;
        }

        public static List<Form> LoadForms()
        {
            var objForms = new List<Form>();

            using (var dbContext = new ApplicationDbContext())
            {
                objForms = dbContext.Forms.Where(c => c.Active == true).ToList();
            }

            objForms.Insert(0, new Form { Id = 0, FormName = "Select", Active = true });

            return objForms;
        }

        public static List<Household> LoadHouseholds()
        {
            var objHouseholds = new List<Household>();

            using (var dbContext = new ApplicationDbContext())
            {
                objHouseholds = dbContext.Households.ToList();
            }

            objHouseholds.Insert(0, new Household { Id = 0, RegistrationNumber = "Select" });

            return objHouseholds;
        }

        public static List<IndividualMember> LoadMembers()
        {
            var objMembers = new List<IndividualMember>();

            using (var dbContext = new ApplicationDbContext())
            {
                objMembers = dbContext.IndividualMembers.ToList();
            }

            objMembers.Insert(0, new IndividualMember { Id = 0, Name = "Select", Surname = "" });

            return objMembers;
        }

        public static CHW CurrentCHW()
        {
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindById(HttpContext.Current.User.Identity.GetUserId());

            return user.CHW;
        }

        public static List<QuestionCategory> LoadQuestionCategories()
        {
            var objQuestionCategories = new List<QuestionCategory>();

            using (var dbContext = new ApplicationDbContext())
            {
                objQuestionCategories = dbContext.QuestionCategories.ToList();

                foreach (var val in objQuestionCategories)
                {
                    val.Questions = dbContext.Questions.Where(q => q.QuestionCategory_Id == val.Id).ToList();
                }
            }

            return objQuestionCategories;
        }

        public static HouseholdRegistrationViewModel LoadHouseholdRegistration()
        {
            HouseholdRegistrationViewModel objHouseholdRegistration = new HouseholdRegistrationViewModel();
            objHouseholdRegistration.Clinics = LoadClinics();
            objHouseholdRegistration.Wards = LoadWards();
            objHouseholdRegistration.CHW = CurrentCHW();
            objHouseholdRegistration.Households = LoadHouseholds();
            objHouseholdRegistration.QuestionCategories = LoadQuestionCategories();


            return objHouseholdRegistration;
        }

        public static IndividualAdultHealthRecordViewModel LoadIndividualAdultHealthRecord()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        public static IndividualAdultHealthRecordViewModel LoadMaternalandChildHealthRecord()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        public static IndividualAdultHealthRecordViewModel LoadOutreachTeamMonthlySummary()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        public static IndividualAdultHealthRecordViewModel LoadReferral()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();
            return objIndividualHealthRecord;
        }

        public static IndividualAdultHealthRecordViewModel LoadVisitSummary()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }
    }
}