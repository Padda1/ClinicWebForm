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
    [Authorize]
    public class DocumentsController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectedForm(int id)
        {
            string viewName = "";

            switch (id)
            {
                case 1:
                    viewName += "HouseholdRegistration/_CreateHouseHoldRegistration";
                    break;
                case 2:
                    viewName += "IndividualAdultHealthRecord/_CreateIndividualAdultHealthRecord";
                    break;
                case 3:
                    viewName += "MaternalandChildHealthRecord/_CreateMaternalandChildHealthRecord";
                    break;
                case 4:
                    viewName += "_CreateOTTemplate";
                    break;
                case 5:
                    viewName += "Referral/_CreateReferralForm";
                    break;
                case 6:
                    viewName += "_CreateVisitTick";
                    break;
            }

            LoadClinics();
            LoadWards();

            return PartialView(viewName);
        }

        private void LoadClinics()
        {
            List<SelectListItem> objClinics = new List<SelectListItem>();

            using(var dbContext = new ApplicationDbContext())
            {
                var clinics = dbContext.Clinics.ToList();

                foreach(var clinic in clinics)
                {
                    objClinics.Add(new SelectListItem { Value = clinic.Id.ToString(), Text = clinic.ClinicDescription });
                }
            }

            ViewBag.Clinics = objClinics;
        }

        private void LoadWards()
        {
            List<SelectListItem> objWard = new List<SelectListItem>();

            using (var dbContext = new ApplicationDbContext())
            {
                var wards = dbContext.Wards.ToList();

                foreach (var ward in wards)
                {
                    objWard.Add(new SelectListItem { Value = ward.Id.ToString(), Text = ward.WardDescription });
                }
            }

            ViewBag.Wards = objWard;
        }

        public ActionResult ListAll()
        {
            return View();
        }
    }
}