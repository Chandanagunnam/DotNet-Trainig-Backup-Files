using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewEx.Models;

namespace PartialViewEx.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public List<Student> ChennaiDetails()
        {
            List<Student> Ch = new List<Student>();
            Ch.Add(new Student { Psno = 1, Name = "Sweety", Location = "Chennai" });
            Ch.Add(new Student { Psno = 2, Name = "Bunty", Location = "Chennai" });
            Ch.Add(new Student { Psno = 3, Name = "Frooty", Location = "Chennai" });
            return Ch;
        }
        public List<Student> BangaloreDetails()
        {
            List<Student> Bang = new List<Student>();
            Bang.Add(new Student { Psno = 4, Name = "Bubbly", Location = "Chennai" });
           Bang.Add(new Student { Psno = 5, Name = "Sunny", Location = "Chennai" });
            Bang.Add(new Student { Psno = 6, Name = "Shiny", Location = "Chennai" });
            return Bang;
        }

        public ActionResult Chennailist()
        {
            return View(new Student() { students = ChennaiDetails() });
        }

        public ActionResult Bangalorelist()
        {
            return View(new Student() { students = BangaloreDetails() });
        }
    }

}