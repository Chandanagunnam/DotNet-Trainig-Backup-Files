using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApplication.Controllers
{
    public class ViewData_Bag_TempdataController : Controller
    {
        // GET: ViewData_Bag_Tempdata
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rules()
        {
            List<string> rule = new List<string>()
            { "Avoid T-shirt","Carry Your Id Card"};
            //Both viewbag and viewdata used to transfer data from controller to view
            //Dynamic property
            //ViewBag.variablename = value;
            ViewBag.getrules = rule;
            //Not a dynamic property
            //ViewData["variablename"]=value;
            ViewData["follow"] = rule;
            return View();
        }

        public ActionResult FirstRequest()
        {
            List<string> TempDataTest = new List<string>();
            TempDataTest.Add("Tejas");
            TempDataTest.Add("Rashi");
            TempDataTest.Add("Sunny");
            TempDataTest.Add("Pooja");
            TempData["Emp"] = TempDataTest;

            //To retain data for any number of subsequent request
            TempData.Keep();
            return View();
        }

        public ActionResult SecondRequest()
        {
            List<string> n = TempData["Emp"] as List<string>;
            return View(n);
        }
    }
}