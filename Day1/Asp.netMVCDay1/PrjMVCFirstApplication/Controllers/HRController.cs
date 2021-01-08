using PrjMVCFirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApplication.Controllers
{
    public class HRController : Controller
    {

        // GET: HR
       /* public ActionResult Index()
        {
            return View();
        }*/
            public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee();
            emp.id = 1001;
            emp.name = "Banu";
            emp.age = 32;
            return View(emp);
        }
        public ActionResult ListDisplayEmployee()
        {
            List<Employee> e = new List<Employee>();
            e.Add(new Employee { id = 1001, name = "Saai", age =25});
            e.Add(new Employee { id = 1002, name = "Abi", age =29});
            e.Add(new Employee { id = 1003 , name = "Emily", age =24});
            return View(e);
        }

        //3.Calling a ListDepartmentdetails action method in index inside the same controller
        // GET: HR
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { id = 10, dname = "MECH" });
            d.Add(new Department { id = 11, dname = "CSE" });
            d.Add(new Department { id = 12, dname = "PET" });
            d.Add(new Department { id = 13, dname = "ECE" });

            return View("ListDepartmentdetails",d);
        }

        //4
        public ActionResult ListDepartmentdetails(Department department)
        {
            return View(department);
        }

        //5
        //calling action metgod from another controller(Home)
        //call contact action method of homecontroller
        public ActionResult CallContact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }
        //6 Redirect
        public ActionResult RedirectMethod()
        {
                                    //ActionMethodName ,ControllerName
            return RedirectToAction("FirstMethod", "Demo");
        }

        public ActionResult Tempdatafrom()
        {
            List<string> n1 = TempData["Emp"] as List<string>;
            return View(n1);
        }
    }
}