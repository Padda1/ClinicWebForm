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
    public class IndividualMembersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IndividualMembers
        public async Task<ActionResult> Index()
        {
            return View(await db.IndividualMembers.ToListAsync());
        }

        // GET: IndividualMembers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndividualMember individualMember = await db.IndividualMembers.FindAsync(id);
            if (individualMember == null)
            {
                return HttpNotFound();
            }
            return View(individualMember);
        }

        // GET: IndividualMembers/Create
        public ActionResult Create()
        {
            List<SelectListItem> gender = new List<SelectListItem>();
            gender.Add(new SelectListItem() { Value = "NULL", Text = "Select" });
            gender.Add(new SelectListItem() { Value = "Male",Text = "Male"});
            gender.Add(new SelectListItem() { Value = "Female", Text = "Female" });

            ViewBag.Gender = gender;
            return PartialView();
        }

        // POST: IndividualMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Surname,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head,IsReferral")] IndividualMember individualMember)
        {
            if (ModelState.IsValid)
            {
                db.IndividualMembers.Add(individualMember);
                await db.SaveChangesAsync();

                return RedirectToAction("SelectedForm", "Documents");
            }

            return View(individualMember);
        }

        // GET: IndividualMembers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndividualMember individualMember = await db.IndividualMembers.FindAsync(id);
            if (individualMember == null)
            {
                return HttpNotFound();
            }
            return View(individualMember);
        }

        // POST: IndividualMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Surname,DOB,Age,Gender,Tel,BirthWeight,ReceivingGrant,Head,IsReferral")] IndividualMember individualMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(individualMember).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(individualMember);
        }

        // GET: IndividualMembers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndividualMember individualMember = await db.IndividualMembers.FindAsync(id);
            if (individualMember == null)
            {
                return HttpNotFound();
            }
            return View(individualMember);
        }

        // POST: IndividualMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IndividualMember individualMember = await db.IndividualMembers.FindAsync(id);
            db.IndividualMembers.Remove(individualMember);
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
