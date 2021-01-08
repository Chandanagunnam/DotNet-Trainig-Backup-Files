using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCRUD_EF.Models;

namespace PrjCRUD_EF.Controllers
{
    public class LinqController : Controller
    {

        NorthwindEntities db = new NorthwindEntities();
        // GET: Linq
        public ActionResult Index()
        {
            return View();
        }
        
        //Display the customer details groupby region

        public ActionResult GetCustomerDetails()
        {
            List<String> c = (from cust in db.Customers
                                group cust by cust.Region into R
                                select R.Key).ToList();
            return View(c);
        }

        //Display the customer who is from germany

        public ActionResult GetGermanyCustomer()
        {
            List<Customer> c = (from cust in db.Customers
                                where cust.Country == "Germany"
                              select cust).ToList();
                       return View(c);
        }

        //Display Employeedetails whose region is not null

        public ActionResult GetEmployeebyRegionNotNull()
        {
            List<Employee> e = (from emp in db.Employees
                                where emp.Region != null
                                select emp).ToList();
            return View(e);
        }

        //display customerinfo for orderid =10248

        public ActionResult GetCustInfoForOrderId()
        {
            List<Customer> cu = (from c in db.Customers
                                join o in db.Orders
         on c.CustomerID equals o.CustomerID
                                where o.OrderID == 10248
                                select  c).ToList();
            return View(cu);
        }
    }
}