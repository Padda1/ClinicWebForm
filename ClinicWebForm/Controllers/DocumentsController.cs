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
    [Authorize]
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
            switch (id)
            {
                case 1:
                    return LoadHouseholdRegistration(null);
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
                    return RedirectToAction("Index");
            }
        }

        private PartialViewResult LoadHouseholdRegistration(HouseholdRegistrationViewModel model)
        {
            string viewName = "HouseholdRegistration/_CreateHouseHoldRegistration";

            if (model == null)
            {
                var householdRegForm = AppUtils.LoadHouseholdRegistration();
                TempData["CHW"] = householdRegForm.CHW.Id;
                return PartialView(viewName, householdRegForm);
            }
            else
            {
                return PartialView(viewName, model);
            }
        }

        private PartialViewResult LoadIndividualAdultHealthRecord()
        {
            string viewName = "IndividualAdultHealthRecord/_CreateIndividualAdultHealthRecord";
            var objIndividualHealthRecord = AppUtils.LoadIndividualAdultHealthRecord();

            return PartialView(viewName);
        }

        private PartialViewResult LoadMaternalandChildHealthRecord()
        {
            string viewName = "MaternalandChildHealthRecord/_CreateMaternalandChildHealthRecord";
            return PartialView(viewName);
        }

        private PartialViewResult LoadOutreachTeamMonthlySummary()
        {
            string viewName = "OutreachTeamMonthlySummary/_CreateOutreachTeamMonthlySummary";
            return PartialView(viewName);
        }

        private PartialViewResult LoadReferral()
        {
            string viewName = "Referral/_CreateReferralForm";
            var objReferral = AppUtils.LoadReferral();
            return PartialView(viewName,objReferral);
        }

        private PartialViewResult LoadVisitSummary()
        {
            string viewName = "_CreateVisitTick";
            return PartialView(viewName);
        }

        public async Task<ActionResult> SubmitHouseHoldRegistration(FormDocumentViewModel model)
        {
            model.FormId = 1;
            model.ClinicId = Convert.ToInt32(Request.Form["Clinics"].ToString());
            model.WardId = Convert.ToInt32(Request.Form["Wards"].ToString());
            model.HouseholdId = Convert.ToInt32(Request.Form["Households"].ToString());

            int chwId = Convert.ToInt32(TempData["CHW"].ToString());

            if (ModelState.IsValid == false)
            {
                return LoadHouseholdRegistration(null);
            }

            FormDocument document = new FormDocument();

            using (var dbContext = new ApplicationDbContext())
            {
                document.Form = dbContext.Forms.Where(f => f.Id == model.FormId).First();
                document.Clinic = dbContext.Clinics.Where(c => c.Id == model.ClinicId).First();
                document.Ward = dbContext.Wards.Where(w => w.Id == model.WardId).First();

                Visit visit = new Visit();
                visit.CHW = dbContext.CHWs.Where(c => c.Id == chwId).First();
                visit.VisitDate = DateTime.Now;

                if (visit.FormDocuments == null)
                {
                    visit.FormDocuments = new List<FormDocument>();
                }

                document.Household = dbContext.Households.Where(hh => hh.Id == model.HouseholdId).First();
                document.Household.Visits.Add(visit);

                visit.FormDocuments.Add(document);

                await dbContext.SaveChangesAsync();
            }

            TempData["FormId"] = model.FormId;
            TempData["FormDocumentId"] = document.Id;
            TempData["HouseholdId"] = document.Household.Id;

            return RedirectToAction("Create", "Houses");
        }

        public ActionResult ListAll()
        {
            return View();
        }
    }
}