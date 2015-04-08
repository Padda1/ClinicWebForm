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
            //TODO: Update to use the actual file
            FileHelperEngine engine = new FileHelperEngine(typeof(string));
            return engine.ReadFileAsDT(path);
        }

        private void ImportFileIntoDatabase(string path)
        {
            DataTable data = LoadIntoCollection(path);

            foreach(DataRow row in data.Rows)
            {
                //TODO: Split columns into objects
            }
        }
    }
}