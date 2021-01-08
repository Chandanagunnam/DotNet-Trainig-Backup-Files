using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace prjFilterEx.Controllers
{
    [HandleError]
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users = "admin@gmail.com")]
        public ActionResult AddProduct()
        {
            return View();
        }

        [Authorize(Users = "admin@gmail.com")]
        public ActionResult DeleteProduct()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult ViewProduct()
        {
            return View();
        }


        [Authorize(Users = "chandu@gmail.com")]
        public ActionResult Cart()
        {
            return View();
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DZError")]
        [AllowAnonymous]//bypass authentication for only this action method

        public ActionResult AnotherProduct()
        {
            int num1 = 0, num2 = 10, result = 0;
            result = num2 / num1;
            return View();
        }

        public ActionResult Fruits()
        {
            string[] fruits = { "Mango", "Apple" };
            ViewBag.fruit = fruits[2];
            return View();
        }
    }

}