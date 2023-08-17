using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                GetQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public decimal GetQuote(Insuree insuree)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {


                /* mapping variables to insuree properties */

                var carYear = insuree.CarYear;
                var carModel = insuree.CarModel;
                var carMake = insuree.CarMake;
                var speedingTickets = insuree.SpeedingTickets;
                var dui = insuree.DUI;
                var coverageType = insuree.CoverageType;

                decimal quote = 50m; // sets the base quote at 50.00


                /* Insuree age conditions */

                var age = DateTime.Today.Year - insuree.DateOfBirth.Year;
                // if insuree age is under 18, add 100m to quote
                if (age <= 18) { quote += 100m; }
                //else if both conditions are true add 50$ to quote
                else if (age >= 19 && age <= 25) { quote += 50m; }
                //else if insuree is over 25, add 25$ to quote
                else if (age > 26) { quote += 25m; }

                /* Car detail conditions */

                //if car year is before 2000, add 25$ to quote
                if (carYear < 2000) { quote += 25m; }
                //else if car is made after 2015, add 25$ to quote
                else if (carYear > 2015) { quote += 25m; }

                //if car make is a porsche, add 25$ to quote - to lower
                if (carMake.ToLower() == "porsche") { quote += 25m; }
                //if car make is porsche and car model is 911 carrera, add 50$ to quote
                if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera") { quote += 50m; }

                /* Driver detail conditions */

                //add 10$ to quote for each speeding ticket driver has
                quote += speedingTickets * 10m;
                // additional 25% of quote if driver has dui
                if (dui == true) { quote *= 1.25m; }
                // additional 50% of quote if driver chooses full coverage
                if (coverageType == true) { quote *= 1.5m; }

                //set final calculated quote to insurre quote column, and save to db
                insuree.Quote = quote;
                return (quote);
            }




        }
    }
}
