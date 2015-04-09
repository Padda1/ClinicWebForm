﻿using ClinicWebForm.Classes;
using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
                file.SaveAs(path);

                ImportFileIntoDatabase(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }

        private DataTable LoadIntoCollection(string path)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(FileTemplate));
            return engine.ReadFileAsDT(path);
        }

        private void ImportFileIntoDatabase(string path)
        {
            DataTable data = LoadIntoCollection(path);

            foreach(DataRow row in data.Rows)
            {
                Clinic clinic = new Clinic();
                clinic.ClinicDescription = row["ClinicName"].ToString();
                clinic.Active = true;

                AppUtils.InsertClinic(clinic);

                Ward ward = new Ward();
                ward.WardDescription = row["WardNo"].ToString();

                AppUtils.InsertWard(ward);

                CHW chw = new CHW();
                chw.HouseholdIdNumber = row["CHWHouseholdIdentifierNo"].ToString();
                chw.Name = row["CHWName"].ToString();

                AppUtils.InsertCHW(chw);
            }
        }
    }
}