using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjCodeFirstEg.Models;

namespace prjCodeFirstEg.Controllers
{
    public class BikeController : Controller
    {

        VehicleContext d = new VehicleContext();
        Bike bike = new Bike();

        // GET: Bike
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(bike);
        }

        [HttpPost]
        public ActionResult Create(Bike b)
        {
            d.bikes.Add(b);
            d.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}