using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FatFlat.Models;

namespace FatFlat.Controllers
{
    public class FlatController : Controller
    {
        private FlatDatabaseEntities db = new FlatDatabaseEntities();

        //
        // GET: /Flat/

        public ActionResult Index()
        {
            return View(db.Flat.ToList());
        }

        //
        // GET: /Flat/Details/5

        public ActionResult Details(int id = 0)
        {
            Flat flat = db.Flat.Find(id);
            if (flat == null)
            {
                return HttpNotFound();
            }
            return View(flat);
        }

        //
        // GET: /Flat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Flat/Create

        [HttpPost]
        public ActionResult Create(Flat flat)
        {
            if (ModelState.IsValid)
            {
                db.Flat.Add(flat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flat);
        }

        //
        // GET: /Flat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Flat flat = db.Flat.Find(id);
            if (flat == null)
            {
                return HttpNotFound();
            }
            return View(flat);
        }

        //
        // POST: /Flat/Edit/5

        [HttpPost]
        public ActionResult Edit(Flat flat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flat);
        }

        //
        // GET: /Flat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Flat flat = db.Flat.Find(id);
            if (flat == null)
            {
                return HttpNotFound();
            }
            return View(flat);
        }

        //
        // POST: /Flat/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Flat flat = db.Flat.Find(id);
            db.Flat.Remove(flat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}