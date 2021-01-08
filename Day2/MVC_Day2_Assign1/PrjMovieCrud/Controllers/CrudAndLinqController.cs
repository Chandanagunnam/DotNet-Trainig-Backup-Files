using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjMovieCrud.Models;

namespace PrjMovieCrud.Controllers
{
    public class CrudAndLinqController : Controller
    {
        dbmovieEntities db = new dbmovieEntities();
        // GET: Crud
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllDetails()
        {
            return View(db.tblmovies.ToList());
        }
        #region Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(tblmovie tbmovie)
        {
            db.tblmovies.Add(tbmovie);
            db.SaveChanges();
            return RedirectToAction("GetAllDetails");
        }
        #endregion
        #region Delete
        public ActionResult Delete(int id)
        {
            tblmovie tbmovie = db.tblmovies.Find(id);
            db.tblmovies.Remove(tbmovie);
            db.SaveChanges();
            return RedirectToAction("GetAllDetails");
        }
        #endregion

        #region Details
        public ActionResult Details(int id)
        {
            tblmovie tbmovie = db.tblmovies.Find(id);

            return View(tbmovie);
        }
        #endregion

        #region Edit
        public ActionResult Edit(int id)
        {
            tblmovie tbmovie = db.tblmovies.Find(id);

            return View(tbmovie);
        }

        [HttpPost]
        public ActionResult Edit(tblmovie m)
        {
            tblmovie tbmovie = db.tblmovies.Find(m.movieid); 
            tbmovie.moviename = m.moviename;
            tbmovie.YearOfMovie = m.YearOfMovie;
            tbmovie.releasedate = m.releasedate;
            db.SaveChanges();
            return RedirectToAction("GetAllDetails");
        }
        #endregion

        #region query

        public ActionResult GetMovieByYear()
        {
            DateTime dateTime = new DateTime(2019,01,01);
            List <String> mo = (from m in db.tblmovies
                                where m.YearOfMovie == dateTime
                                  select m.moviename).ToList();
            return View(mo);
        }
        #endregion
    }
}