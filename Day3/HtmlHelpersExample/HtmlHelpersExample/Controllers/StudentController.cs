using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersExample.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult StronglyTypedCreate()
        {
            return View();
        }

        //TemplatedHelper 1
        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //TemplatedHelper 2
        public ActionResult EditorForModelEg()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}