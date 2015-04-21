using ClinicWebForm.Classes;
using ClinicWebForm.Context;
using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    viewName += "IndividualAdultHealthRecord/_CreateIndividualAdultHealthRecord";
                    return PartialView(viewName);
                case 3:
                    viewName += "MaternalandChildHealthRecord/_CreateMaternalandChildHealthRecord";
                    return PartialView(viewName);
                case 4:
                    viewName += "OutreachTeamMonthlySummary/_CreateOutreachTeamMonthlySummary";
                    LoadOutreachTeamMonthlySummary();
                    return PartialView(viewName);
                case 5:
                    viewName += "Referral/_CreateReferralForm";
                    return PartialView(viewName);
                case 6:
                    viewName += "_CreateVisitTick";
                    return PartialView(viewName);
                default:
                    return PartialView(viewName);
            }
        }

        private PartialViewResult LoadHouseholdRegistration()
        {
            string viewName = "HouseholdRegistration/_CreateHouseHoldRegistration";
            var householdRegForm = LoadHouseholdRegistrationObject();

            return PartialView(viewName,householdRegForm);
        }

        public HouseholdRegistrationViewModel LoadHouseholdRegistrationObject()
        {
            HouseholdRegistrationViewModel objHouseholdRegistration = new HouseholdRegistrationViewModel();
            objHouseholdRegistration.Clinics = AppUtils.LoadClinics();
            objHouseholdRegistration.Wards = AppUtils.LoadWards();
            //objHouseholdRegistration.CHW = AppUtils.LoadCHW();

            return objHouseholdRegistration;
        }

        public void LoadOutreachTeamMonthlySummary()
        {
            ViewBag.Clinics = AppUtils.LoadClinics();
            ViewBag.Wards = AppUtils.LoadWards();
        }

        public ActionResult ListAll()
        {
            return View();
        }
    }
}