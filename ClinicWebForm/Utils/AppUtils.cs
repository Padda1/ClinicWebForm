using ClinicWebForm.Context;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Utils
{
    public class AppUtils
    {
        public static string WordTemplateDirectory = HttpContext.Current.Server.MapPath("~/DocumentTemplates/");

        public static List<SelectListItem> LoadClinics()
        {
            List<SelectListItem> objClinics = new List<SelectListItem>();

            using (var dbContext = new ApplicationDbContext())
            {
                var clinics = dbContext.Clinics.Where(c => c.Active == true).ToList();

                foreach (var clinic in clinics)
                {
                    objClinics.Add(new SelectListItem { Value = clinic.Id.ToString(), Text = clinic.ClinicDescription });
                }
            }

            return objClinics;
        }

        public static List<SelectListItem> LoadWards()
        {
            List<SelectListItem> objWard = new List<SelectListItem>();

            using (var dbContext = new ApplicationDbContext())
            {
                var wards = dbContext.Wards.Where(c => c.Active == true).ToList();

                foreach (var ward in wards)
                {
                    objWard.Add(new SelectListItem { Value = ward.Id.ToString(), Text = ward.WardDescription });
                }
            }

            return objWard;
        }
    }
}