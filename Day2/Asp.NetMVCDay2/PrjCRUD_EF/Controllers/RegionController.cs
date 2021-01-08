using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCRUD_EF.Models;

namespace PrjCRUD_EF.Controllers
{
    public class RegionController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Region
        public ActionResult Index()
        {
            return View();
        }
        //Parameter 
        [HttpPost] 
        public ActionResult Create(int RegionID,string RegionDescription) 
            { 
            Region r = new Region();
            r.RegionID = RegionID; 
            r.RegionDescription = RegionDescription; 
            db.Regions.Add(r); 
            db.SaveChanges();  return View(); 
        }

        #region Request
         [HttpPost]
         [ActionName("Create")] 
            public ActionResult CreatePost() 
        { 
            Region region = new Region();
            region.RegionID = Convert.ToInt32(Request["RegionID"]); 
            region.RegionDescription = Request["RegionDescription"].ToString(); 
            db.Regions.Add(region);
            db.SaveChanges(); 
            return View(); 
        } 
        #endregion

    }
}