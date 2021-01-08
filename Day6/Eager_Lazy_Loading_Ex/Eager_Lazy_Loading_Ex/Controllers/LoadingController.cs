using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Eager_Lazy_Loading_Ex.Models;

namespace Eager_Lazy_Loading_Ex.Controllers
{
    public class LoadingController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Loading
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EagerLoading()
        {
            //Disable Lazy Loading
            db.Configuration.LazyLoadingEnabled = false;

            var sup = db.Suppliers.Include("Products").ToList();

            //Products supplied by particular supplier
            var supplier1 = (from s in db.Suppliers
                             .Include("Products") // Product model table to be included in the result
                             where s.SupplierID == 20
                             select s).ToList();

            return View(sup);
        }
        
        
        
    


        //1. Display the fullname of the employee
        public ActionResult EmpName()
        {
            var name = (from e in db.Employees
                        select e.FirstName + e.LastName);
            return View(name);

        }

        // 2. Display the customer details who has Fax number 

        public ActionResult CustWithFax()
        {
            var cd = (from c in db.Customers
                         where c.Fax != null
                         select c);
            return View(cd);
        }

        //3. select order Details where unit price is greater than 10 and less than 20

        public ActionResult ODPrice()
        {
            var od = (from o in db.Order_Details
                      where o.UnitPrice > 10 && o.UnitPrice < 20
                      select o);
            return View(od);
        }


        //    4. Display order details which contains shipping date and arrange the order by date 

        public ActionResult ODDate()
        {
            var od = (from o in db.Orders
                      where o.ShippedDate != null
                      orderby o.ShippedDate
                      select o);
            return View(od);
        }

        // 5. Print the orders shipped by ship name 'La corne d'abondance' between 2 dates(Choose dates of your choice)*/


        public ActionResult ShipName()
        {
            DateTime dateTime = new DateTime(1989, 02, 01);
            DateTime dateTime1 = new DateTime(2005, 03, 01);
            var s = (from o in db.Orders
                     where ((o.ShipName=="La corne d'abondance") 
                     && (o.ShippedDate >= dateTime && o.ShippedDate <= dateTime1 ))
                select o).ToList();
            return View(s);
                     
        }

    }
}