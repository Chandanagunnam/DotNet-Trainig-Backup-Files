using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCRUD_EF.Models;

namespace PrjCRUD_EF.Controllers
{
    public class MultipleTableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultipleTable
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderCustomerInfo()
        {

            return View(db.Orders.ToList());
        }
    }
}