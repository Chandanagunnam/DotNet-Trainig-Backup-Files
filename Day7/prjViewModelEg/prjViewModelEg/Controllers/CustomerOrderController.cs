using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjViewModelEg.ViewModel;
using prjViewModelEg.Models;
using System.Data.Entity.Core.Metadata.Edm;

namespace prjViewModelEg.Controllers
{
    public class CustomerOrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: CustomerOrder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CusOrder()
        {
            List<CustomerVM> CustomerVMlist = new List<CustomerVM>();
            //query getting data from database from joining 2 tables and storing data in customer list
            var customerlist = (from cust in db.Customers
                                join or in db.Orders
                                on cust.CustomerID equals or.CustomerID
                                select new { cust.CustomerID, cust.CompanyName, cust.ContactName, or.OrderID, or.OrderDate }).ToList();
            //using foreach loop to fill data from customerlist to List<Customer.VM>
            foreach(var item in customerlist)
            {
                CustomerVM objcvm = new CustomerVM(); //ViewModel
               
                
                objcvm.CustomerID = item.CustomerID;
                objcvm.CompanyName = item.CompanyName;
                objcvm.ContactName = item.ContactName;
                objcvm.OrderID = item.OrderID;
                objcvm.OrderDate = item.OrderDate;

                CustomerVMlist.Add(objcvm);


            }
            //List of CustomerVM (ViewModel)
            return View(CustomerVMlist);

        }
    }
}