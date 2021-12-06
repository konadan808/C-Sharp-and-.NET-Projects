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
        // This method is used to filter through the values a user inputs and compares them to conditions that affect the monthy cost to insure them.  This method is callable to the "Create" and "Edit" methods in order to calculate upon creation of an "Insuree" object and to change costs when editing an "Insuree" object.
        public void Calculate(Insuree insuree)
        {
            // This is the base cost for an insurance plan
            decimal baseCost = 50;

            // "ageCost" has a default of 25 as a minimum charge.  Should the insuree be under 18, the value of "ageCost" is increased to 100, or if the insuree is bewteen 18 and 25 years of age, the value of "ageCost" is 50.
            decimal ageCost = 25;
            var today = DateTime.Today;
            var age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > today.AddYears(-18))
            {
                ageCost = 100;
            }
            else if (insuree.DateOfBirth.Date < today.AddYears(-18) && insuree.DateOfBirth.Date > today.AddYears(-25))
            {
                ageCost = 50;
            }

            // The default value of "carYearCost" is zero unless the "CarYear" was manufactured before the year 2000 or after the year 2015
            decimal carYearCost = 0;
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                carYearCost = 25;
            }

            // This default value is 0 unless the insuree is driving a Porsche, in which case the value of "makeCost" is increased to 25.
            decimal makeCost = 0;
            if (insuree.CarMake == "Porsche")
            {
                makeCost = 25;
            }

            // This default is zero, unless the insure is driving a 911 Carrena model.  In that case, "modelCost" would be increased to 25.
            decimal modelCost = 0;
            if (insuree.CarModel == "911 Carrera")
            {
                modelCost = 25;
            }

            // This "speedingCost" calcualtes any additional fees should the insuree mark down any speeding tickets that they have received, in which a value of 10 would be applied to every speeding ticket.
            decimal speedingCost = insuree.SpeedingTickets * 10;

            // This sums up the total amount of costs by adding the values of the cost variable above and assign the value to "quoteTotal"
            decimal quoteTotal = baseCost + ageCost + carYearCost + makeCost + modelCost + speedingCost;

            // This if statement determiens that if the insuree has gotten a DUI, their total is increased by 25%.
            if (insuree.DUI == true)
            {
                quoteTotal = quoteTotal + (quoteTotal * .25m);
            }

            // This if statement determiens that if the insuree chooses full coverage, their total is increased by 50%.
            if (insuree.CoverageType == true)
            {
                quoteTotal = quoteTotal + (quoteTotal * .5m);
            }
            // This line assigns the value of "quoteTotal" to the "insuree" object property "Quote"
            insuree.Quote = quoteTotal;
        }

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
            // This calls the method "Calculate" and gets the sum of all chargeable properties that are applicable.
            Calculate(insuree);

            if (ModelState.IsValid)
            {
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
            // This calls the method "Calculate" and gets the sum of all chargeable properties that are applicable.
            Calculate(insuree);

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
    }
}
