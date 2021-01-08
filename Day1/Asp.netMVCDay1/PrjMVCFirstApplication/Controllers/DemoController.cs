using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjMVCFirstApplication.Models;

namespace PrjMVCFirstApplication.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        //1.ActionMethod returning actionresult

        public ActionResult FirstMethod()
        {
            return View();
        }
        //2.ActionMethod returning ViewResult

        public ViewResult SecondMethod()
        {
            return View();
        }
        //3. Only for displaying set of strigs -- returns content in html page
        public ContentResult Reply()
        {
            //return Content("Good Morning All","text/plain");
            return Content("<h1>Good Morning All</h1>","text/html");
        }
        //4 Empty Result--
        [NonAction]
        public EmptyResult Result()
        {
            int amount = 45000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }
        //5. Returning as Json Result
        public JsonResult Empdata()
        {
            Employee employee = new Employee();
            employee.id = 101;
            employee.name = "Sunil";
            employee.age = 25;
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }

}