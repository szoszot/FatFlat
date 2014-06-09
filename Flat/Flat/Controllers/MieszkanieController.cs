using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flat.Models;

namespace Flat.Controllers
{
    public class MieszkanieController : Controller
    {
        private MieszkaniaBazaEntities db = new MieszkaniaBazaEntities();

        //
        // GET: /Mieszkanie/

        public ActionResult Index()
        {
            return View(db.Mieszkanie.ToList());
        }

        //
        // GET: /Mieszkanie/Details/5

        public ActionResult Details(int id = 0)
        {
            Mieszkanie mieszkanie = db.Mieszkanie.Find(id);
            if (mieszkanie == null)
            {
                return HttpNotFound();
            }
            return View(mieszkanie);
        }

        //
        // GET: /Mieszkanie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mieszkanie/Create

        [HttpPost]
        public ActionResult Create(Mieszkanie mieszkanie)
        {
            if (ModelState.IsValid)
            {
                db.Mieszkanie.Add(mieszkanie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mieszkanie);
        }

        //
        // GET: /Mieszkanie/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Mieszkanie mieszkanie = db.Mieszkanie.Find(id);
            if (mieszkanie == null)
            {
                return HttpNotFound();
            }
            return View(mieszkanie);
        }

        //
        // POST: /Mieszkanie/Edit/5

        [HttpPost]
        public ActionResult Edit(Mieszkanie mieszkanie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mieszkanie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mieszkanie);
        }

        //
        // GET: /Mieszkanie/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Mieszkanie mieszkanie = db.Mieszkanie.Find(id);
            if (mieszkanie == null)
            {
                return HttpNotFound();
            }
            return View(mieszkanie);
        }

        //
        // POST: /Mieszkanie/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Mieszkanie mieszkanie = db.Mieszkanie.Find(id);
            db.Mieszkanie.Remove(mieszkanie);
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