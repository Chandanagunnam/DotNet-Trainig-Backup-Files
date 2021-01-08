using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjViewModelEg.ViewModel;
using prjViewModelEg.Models;

namespace prjViewModelEg.Controllers
{
    public class ProductCategorySupplierController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: ProductCategorySupplier
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProCatSup()
        {
            List<ProductVM> productVMsList = new List<ProductVM>();

            var Prodlist = (from p in db.Products
                            join c in db.Categories
                            on p.CategoryID equals c.CategoryID
                            join s in db.Suppliers
                            on p.SupplierID equals s.SupplierID
                            select new { p.ProductID, p.ProductName,
                            c.CategoryID, c.CategoryName,
                                s.SupplierID, s.CompanyName
                            }).ToList();

            foreach (var item in Prodlist)
            {
                ProductVM objcvm = new ProductVM(); //ViewModel


                objcvm.ProductID = item.ProductID;
                objcvm.ProductName = item.ProductName;
                objcvm.CategoryID = item.CategoryID;
                objcvm.CategoryName = item.CategoryName;
                objcvm.SupplierID = item.SupplierID;
                objcvm.CompanyName = item.CompanyName;

                productVMsList.Add(objcvm);
            }

            return View(productVMsList);
        }
    }
}