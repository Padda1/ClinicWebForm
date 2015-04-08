using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Controllers
{
    public class VisitController : Controller
    {
        // GET: Visit
        public ActionResult Index()
        {
            List<Visit> visits;

            using (var connection = AppUtils.GetOpenConnection())
            {
                string sql = "select top 100 * from Visit";
                visits = Dapper.SqlMapper.Query<Visit>(connection, sql).ToList();
            }

            return View(visits);
        }

        // GET: Visit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Visit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visit/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Visit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Visit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Visit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Visit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
