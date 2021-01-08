using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using prjStoredProcedure.Models;

namespace prjStoredProcedure.Controllers
{
    public class ForeignKeyController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: ForeignKey
        public ActionResult Index()
        {
            return View(db.Territories.ToList());
        }

        //binded with territories table
        public ActionResult Create()
        {
            ViewBag.Regionid = (from t in db.Territories
                                select t.RegionID).Distinct();

            ViewBag.Regiondescription = (from t in db.Territories
                                         join r in db.Regions
                                         on t.RegionID equals r.RegionID
                                         select r.RegionDescription).Distinct();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Territory territory)
        {
            var rid = territory.RegionID;
            ViewBag.Regionid = (from t in db.Regions
                                select t.RegionID).Distinct();
            db.Territories.Add(territory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}