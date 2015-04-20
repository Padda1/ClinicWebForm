﻿using System;
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
    public class MunicipalitiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Municipalities
        public async Task<ActionResult> Index()
        {
            return View(await db.Municipalities.ToListAsync());
        }

        // GET: Municipalities/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipality municipality = await db.Municipalities.FindAsync(id);
            if (municipality == null)
            {
                return HttpNotFound();
            }
            return View(municipality);
        }

        // GET: Municipalities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Municipalities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,MunicipalCode,MunicipalName")] Municipality municipality)
        {
            if (ModelState.IsValid)
            {
                db.Municipalities.Add(municipality);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(municipality);
        }

        // GET: Municipalities/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipality municipality = await db.Municipalities.FindAsync(id);
            if (municipality == null)
            {
                return HttpNotFound();
            }
            return View(municipality);
        }

        // POST: Municipalities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,MunicipalCode,MunicipalName")] Municipality municipality)
        {
            if (ModelState.IsValid)
            {
                db.Entry(municipality).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(municipality);
        }

        // GET: Municipalities/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipality municipality = await db.Municipalities.FindAsync(id);
            if (municipality == null)
            {
                return HttpNotFound();
            }
            return View(municipality);
        }

        // POST: Municipalities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Municipality municipality = await db.Municipalities.FindAsync(id);
            db.Municipalities.Remove(municipality);
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
