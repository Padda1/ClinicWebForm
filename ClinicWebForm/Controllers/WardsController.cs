using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClinicWebForm.Context;
using ClinicWebForm.Models;

namespace ClinicWebForm.Controllers
{
    public class WardsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Wards
        public async Task<ActionResult> Index()
        {
            return View(await db.Wards.ToListAsync());
        }

        // GET: Wards/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // GET: Wards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,WardDescription,Active")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Wards.Add(ward);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ward);
        }

        // GET: Wards/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,WardDescription,Active")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ward).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ward);
        }

        // GET: Wards/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ward ward = await db.Wards.FindAsync(id);
            db.Wards.Remove(ward);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
