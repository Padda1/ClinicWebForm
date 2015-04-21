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
            ViewBag.Forms = AppUtils.LoadForms();

            return View();
        }

        public ActionResult SelectedForm(int id)
        {
            string viewName = "";

            switch (id)
            {
                case 1:
                    viewName += "HouseholdRegistration/_CreateHouseHoldRegistration";
                    LoadHouseholdRegistration();
                    break;
                case 2:
                    viewName += "IndividualAdultHealthRecord/_CreateIndividualAdultHealthRecord";
                    break;
                case 3:
                    viewName += "MaternalandChildHealthRecord/_CreateMaternalandChildHealthRecord";
                    break;
                case 4:
                    viewName += "OutreachTeamMonthlySummary/_CreateOutreachTeamMonthlySummary";
                    LoadOutreachTeamMonthlySummary();
                    break;
                case 5:
                    viewName += "Referral/_CreateReferralForm";
                    break;
                case 6:
                    viewName += "_CreateVisitTick";
                    break;
            }

            return PartialView(viewName);
        }

        public void LoadHouseholdRegistration()
        {
            ViewBag.Clinics = AppUtils.LoadClinics();
            ViewBag.Wards = AppUtils.LoadWards();
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