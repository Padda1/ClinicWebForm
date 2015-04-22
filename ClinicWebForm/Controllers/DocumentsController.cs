using ClinicWebForm.Classes;
using ClinicWebForm.Context;
using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Controllers
{
    //[Authorize]
    public class DocumentsController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            FormsViewModel formsViewModel = new FormsViewModel();
            formsViewModel.Forms = AppUtils.LoadForms();

            return View(formsViewModel);
        }

        public ActionResult SelectedForm(int id)
        {
            string viewName = "";

            switch (id)
            {
                case 1:
                    return LoadHouseholdRegistration();
                case 2:
                    return LoadIndividualAdultHealthRecord();
                case 3:
                    return LoadMaternalandChildHealthRecord();
                case 4:
                    return LoadOutreachTeamMonthlySummary();
                case 5:
                    return LoadReferral();
                case 6:
                    return LoadVisitSummary();
                default:
                    return PartialView(viewName);
            }
        }

        private PartialViewResult LoadHouseholdRegistration()
        {
            string viewName = "HouseholdRegistration/_CreateHouseHoldRegistration";
            var householdRegForm = LoadHouseholdRegistrationObject();

            return PartialView(viewName, householdRegForm);
        }

        private HouseholdRegistrationViewModel LoadHouseholdRegistrationObject()
        {
            HouseholdRegistrationViewModel objHouseholdRegistration = new HouseholdRegistrationViewModel();
            objHouseholdRegistration.Clinics = AppUtils.LoadClinics();
            objHouseholdRegistration.Wards = AppUtils.LoadWards();
            //objHouseholdRegistration.CHW = AppUtils.LoadCHW();

            return objHouseholdRegistration;
        }

        private PartialViewResult LoadIndividualAdultHealthRecord()
        {
            string viewName = "IndividualAdultHealthRecord/_CreateIndividualAdultHealthRecord";
            var objIndividualHealthRecord = LoadIndividualAdultHealthRecordObject();

            return PartialView(viewName);
        }

        private IndividualAdultHealthRecordViewModel LoadIndividualAdultHealthRecordObject()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        private PartialViewResult LoadMaternalandChildHealthRecord()
        {
            string viewName = "MaternalandChildHealthRecord/_CreateMaternalandChildHealthRecord";
            return PartialView(viewName);
        }

        private IndividualAdultHealthRecordViewModel LoadMaternalandChildHealthRecordObject()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        private PartialViewResult LoadOutreachTeamMonthlySummary()
        {
            string viewName = "OutreachTeamMonthlySummary/_CreateOutreachTeamMonthlySummary";


            return PartialView(viewName);
        }

        private IndividualAdultHealthRecordViewModel LoadOutreachTeamMonthlySummaryObject()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        private PartialViewResult LoadReferral()
        {
            string viewName = "Referral/_CreateReferralForm";
            return PartialView(viewName);
        }

        private IndividualAdultHealthRecordViewModel LoadReferralObject()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }

        private PartialViewResult LoadVisitSummary()
        {
            string viewName = "_CreateVisitTick";
            return PartialView(viewName);
        }

        private IndividualAdultHealthRecordViewModel LoadVisitSummaryObject()
        {
            IndividualAdultHealthRecordViewModel objIndividualHealthRecord = new IndividualAdultHealthRecordViewModel();


            return objIndividualHealthRecord;
        }


        public async Task<ActionResult> SubmitHouseHoldRegistration(HouseholdRegistrationViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return PartialView(model);
            }

            using (var dbContext = new ApplicationDbContext())
            {
                //save items

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public ActionResult ListAll()
        {
            return View();
        }
    }
}