using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SouthFork.DAL;
using SouthFork.Models;

namespace SouthFork.Controllers
{
    [Authorize]
    public class BuildersController : Controller
    {
        private SouthForkDBContext db = new SouthForkDBContext();

        // GET: Builders
        public ActionResult Index()
        {
            return View(db.Builders.ToList());
        }

        // GET: Builders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Builder builder = db.Builders.Find(id);
            if (builder == null)
            {
                return HttpNotFound();
            }
            return View(builder);
        }

        // GET: Builders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Builders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuilderID,CompanyName")] Builder builder)
        {
            if (ModelState.IsValid)
            {
                db.Builders.Add(builder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(builder);
        }

        // GET: Builders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Builder builder = db.Builders.Find(id);
            if (builder == null)
            {
                return HttpNotFound();
            }
            return View(builder);
        }

        // POST: Builders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuilderID,CompanyName")] Builder builder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(builder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(builder);
        }

        // GET: Builders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Builder builder = db.Builders.Find(id);
            if (builder == null)
            {
                return HttpNotFound();
            }
            return View(builder);
        }

        // POST: Builders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Builder builder = db.Builders.Find(id);
            db.Builders.Remove(builder);
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
