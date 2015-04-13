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
    public class QuestionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Questions
        public async Task<ActionResult> Index()
        {
            return View(await db.Questions.ToListAsync());
        }

        // GET: Questions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = await db.Questions.FindAsync(id);
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // GET: Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,QuestionDescription,Active")] Questions questions)
        {
            if (ModelState.IsValid)
            {
                db.Questions.Add(questions);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(questions);
        }

        // GET: Questions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = await db.Questions.FindAsync(id);
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,QuestionDescription,Active")] Questions questions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questions).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(questions);
        }

        // GET: Questions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = await db.Questions.FindAsync(id);
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Questions questions = await db.Questions.FindAsync(id);
            db.Questions.Remove(questions);
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
