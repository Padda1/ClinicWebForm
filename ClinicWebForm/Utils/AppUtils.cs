using ClinicWebForm.Context;
using ClinicWebForm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            return objClinics;
        }

        public static List<Ward> LoadWards()
        {
            var objWards = new List<Ward>();

            using (var dbContext = new ApplicationDbContext())
            {
                objWards = dbContext.Wards.Where(c => c.Active == true).ToList();
            }

            return objWards;
        }

        public static List<Form> LoadForms()
        {
            var objForms = new List<Form>();

            using (var dbContext = new ApplicationDbContext())
            {
                objForms = dbContext.Forms.Where(c => c.Active == true).ToList();
            }

            return objForms;
        }

        //public static CHW LoadCHW()
        //{
            
        //}
    }
}