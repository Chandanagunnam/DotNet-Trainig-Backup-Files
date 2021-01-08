using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieBooking.Models;

namespace MovieBooking.Controllers
{
    public class moviebookingsController : Controller
    {
        private dbmovieEntities db = new dbmovieEntities();

        // GET: moviebookings
        public ActionResult Index()
        {
            var moviebookings = db.moviebookings.Include(m => m.tblcustomer).Include(m => m.tblscreen);
            return View(moviebookings.ToList());
        }

        // GET: moviebookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moviebooking moviebooking = db.moviebookings.Find(id);
            if (moviebooking == null)
            {
                return HttpNotFound();
            }
            return View(moviebooking);
        }

        // GET: moviebookings/Create
        public ActionResult Create()
        {
            ViewBag.cid = new SelectList(db.tblcustomers, "cid", "cname");
            ViewBag.sid = new SelectList(db.tblscreens, "sid", "sid");
            return View();
        }

        // POST: moviebookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bookingid,sid,cid,noofseats,totalamount")] moviebooking moviebooking)
        {
            tblscreen st = new tblscreen();
            var amount = (from s in db.tblscreens
                          where s.sid == moviebooking.sid
                          select s.amount).First();
            var totalAmount = amount * moviebooking.noofseats;
            ViewBag.TotalAmount = totalAmount;

            if (ModelState.IsValid)
            {
                moviebooking.totalamount = (int)totalAmount;
                db.moviebookings.Add(moviebooking);
                tblscreen s2 = db.tblscreens.Find(st.sid = Convert.ToInt32(moviebooking.sid));
                s2.Noofseats = (s2.Noofseats - moviebooking.noofseats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cid = new SelectList(db.tblcustomers, "cid", "cname", moviebooking.cid);
            ViewBag.sid = new SelectList(db.tblscreens, "sid", "sid", moviebooking.sid);
            return View(moviebooking);
        }

        // GET: moviebookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moviebooking moviebooking = db.moviebookings.Find(id);
            if (moviebooking == null)
            {
                return HttpNotFound();
            }
            ViewBag.cid = new SelectList(db.tblcustomers, "cid", "cname", moviebooking.cid);
            ViewBag.sid = new SelectList(db.tblscreens, "sid", "sid", moviebooking.sid);
            return View(moviebooking);
        }

        // POST: moviebookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "bookingid,sid,cid,noofseats,totalamount")] moviebooking moviebooking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moviebooking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cid = new SelectList(db.tblcustomers, "cid", "cname", moviebooking.cid);
            ViewBag.sid = new SelectList(db.tblscreens, "sid", "sid", moviebooking.sid);
            return View(moviebooking);
        }

        // GET: moviebookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moviebooking moviebooking = db.moviebookings.Find(id);
            if (moviebooking == null)
            {
                return HttpNotFound();
            }
            return View(moviebooking);
        }

        // POST: moviebookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            moviebooking moviebooking = db.moviebookings.Find(id);
            tblscreen st = new tblscreen();
            tblscreen s2 = db.tblscreens.Find(st.sid = Convert.ToInt32(moviebooking.sid));
            s2.Noofseats = (s2.Noofseats + Convert.ToInt32(moviebooking.sid));
            
            db.moviebookings.Remove(moviebooking);
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
