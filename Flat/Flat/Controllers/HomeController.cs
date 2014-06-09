using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flat.Models;

namespace Flat.Controllers
{
    public class HomeController : Controller
    {
        private MieszkaniaBazaEntities _entities = new MieszkaniaBazaEntities(); 
        
        public ActionResult Index()
        {
            ViewBag.Message = "\n\t czyli mieszkanie na wypasie";

            return View(_entities.Mieszkanie.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Opis aplikacji.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt.";

            return View();
        }

        // GET: /Home/Create/
        public ActionResult Create()
        {
            return View();
        }
        //
        //POST: /Home/Create/
        [HttpPost]
        public ActionResult Create(Mieszkanie newMieszkanie)
        {

            if (ModelState.IsValid)
            {
                _entities.Mieszkanie.Add(newMieszkanie);
                _entities.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newMieszkanie);
            }
        }
        public ActionResult Edit(int ID) 
        {
            return View("Edit", ID);
        }

    }
    
}
