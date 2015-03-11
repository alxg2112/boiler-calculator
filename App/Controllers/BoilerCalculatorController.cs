using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class BoilerCalculatorController : Controller
    {
        private CalculatorDbContext db = new CalculatorDbContext();

        //
        // GET: /BoilerCalculator/

        public ActionResult Index()
        {
            return View(db.Calculators.ToList());
        }

        //
        // GET: /BoilerCalculator/Details/5

        public ActionResult Details(int id = 0)
        {
            Calculator calculator = db.Calculators.Find(id);
            if (calculator == null)
            {
                return HttpNotFound();
            }
            return View(calculator);
        }

        //
        // GET: /BoilerCalculator/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BoilerCalculator/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                db.Calculators.Add(calculator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calculator);
        }

        //
        // GET: /BoilerCalculator/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Calculator calculator = db.Calculators.Find(id);
            if (calculator == null)
            {
                return HttpNotFound();
            }
            return View(calculator);
        }

        //
        // POST: /BoilerCalculator/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calculator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calculator);
        }

        //
        // GET: /BoilerCalculator/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Calculator calculator = db.Calculators.Find(id);
            if (calculator == null)
            {
                return HttpNotFound();
            }
            return View(calculator);
        }

        //
        // POST: /BoilerCalculator/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calculator calculator = db.Calculators.Find(id);
            db.Calculators.Remove(calculator);
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