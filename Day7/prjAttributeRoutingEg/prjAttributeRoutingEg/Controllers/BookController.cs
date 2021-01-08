using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAttributeRoutingEg.Controllers
{
    //Attribute Routing
    [RoutePrefix("MyBooks")]
    public class BookController : Controller
    {
        // GET: Book

        [Route("AllBooks")]
        public ActionResult GetAllBooks()
        {
            return View();
        }
        //by Id
        //[Route("Book/{id:int}")]

        [Route("id/{id:int?}")]
        public ActionResult GetBookById()
        {
            return View();
        }

        //By name
        //[Route("Book/{name=Ram}")]
        [Route("{name=Ram}")]
        public ActionResult GetBookByAuthor()
        {
            return View();
        }

        //Route Constraint
        //[Route("Book/{name:maxlength(4)}")]
        [Route("{name:maxlength(4)}")]
        public ActionResult GetBookByName(string name)
        {
            return View();
        }

    }
}