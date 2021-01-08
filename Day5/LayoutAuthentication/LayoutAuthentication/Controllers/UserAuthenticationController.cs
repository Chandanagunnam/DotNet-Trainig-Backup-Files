using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayoutAuthentication.Models;

namespace LayoutAuthentication.Controllers
{
    public class UserAuthenticationController : Controller
    {

        dbmovieEntities1 db = new dbmovieEntities1();
        // GET: UserAuthentication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            string username = frm["txtuname"].ToString();
            string password = frm["txtpwd"].ToString();
            var a = (from r in db.tblcustomers
                     where r.cname == username && r.Password == password
                     select r).FirstOrDefault();

            if(a!=null)
            {
                Session["Loginstatus"] = "valid";
                Session["UserId"] = frm["txtuname"];

                return RedirectToAction("Index");
            }
            else
            {
                Session["Loginstatus"] = "Invalid";
                return View();
            }


            /*if (frm["txtuname"] == "Rani" && frm["txtpwd"] == "123")
            {
                Session["Loginstatus"] = "valid";
                Session["UserId"] = frm["txtuname"];
                return RedirectToAction("Index");
            }
            else
            {
                Session["Loginstatus"] = "Invalid";
                return View();
            } */
        }

        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}