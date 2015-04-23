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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

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

            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindById(User.Identity.GetUserId());

            var householdRegForm = AppUtils.LoadHouseholdRegistration(user);

            return PartialView(viewName, householdRegForm);
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
            return PartialView(viewName);
        }

        private PartialViewResult LoadVisitSummary()
        {
            string viewName = "_CreateVisitTick";
            return PartialView(viewName);
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