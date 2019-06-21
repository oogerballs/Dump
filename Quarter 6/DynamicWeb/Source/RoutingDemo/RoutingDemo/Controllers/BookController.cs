using RoutingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult BookList()
        {
            return View();
        }

        public ActionResult PaginatedBookList(PaginationModel model)
        {

            return View(model);
        }

        public ActionResult BookDetailzViewDude(String BookID)
        {
            //var bookId = RouteData.Values["TheBookId"];

            //fetch book detail from database
            var bookDetails = new { };

            BookModel model = new BookModel();

            return View(model);
        }
    }
}