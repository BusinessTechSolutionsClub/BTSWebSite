using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessTechSolutionsWebSite.Models;

namespace BusinessTechSolutionsWebSite.Controllers
{
    public class ClubOfficersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClubOfficers
        public ActionResult Index()
        {
            var clubOfficers = db.ClubOfficers.Include(c => c.Member);
            return View(clubOfficers.ToList());
        }

        // GET: ClubOfficers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubOfficer clubOfficer = db.ClubOfficers.Find(id);
            if (clubOfficer == null)
            {
                return HttpNotFound();
            }
            return View(clubOfficer);
        }

        // GET: ClubOfficers/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Members, "Id", "StudentId");
            return View();
        }

        // POST: ClubOfficers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,officerPosition,beginDate,endDate")] ClubOfficer clubOfficer)
        {
            if (ModelState.IsValid)
            {
                db.ClubOfficers.Add(clubOfficer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Members, "Id", "StudentId", clubOfficer.Id);
            return View(clubOfficer);
        }

        // GET: ClubOfficers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubOfficer clubOfficer = db.ClubOfficers.Find(id);
            if (clubOfficer == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Members, "Id", "StudentId", clubOfficer.Id);
            return View(clubOfficer);
        }

        // POST: ClubOfficers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,officerPosition,beginDate,endDate")] ClubOfficer clubOfficer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clubOfficer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Members, "Id", "StudentId", clubOfficer.Id);
            return View(clubOfficer);
        }

        // GET: ClubOfficers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubOfficer clubOfficer = db.ClubOfficers.Find(id);
            if (clubOfficer == null)
            {
                return HttpNotFound();
            }
            return View(clubOfficer);
        }

        // POST: ClubOfficers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClubOfficer clubOfficer = db.ClubOfficers.Find(id);
            db.ClubOfficers.Remove(clubOfficer);
            db.SaveChanges();
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
