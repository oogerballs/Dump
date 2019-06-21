using ASPNetMVCIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMVCIntro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomePageViewModel model = new HomePageViewModel();

            model.Title = "The Home Page!";
            model.WelcomeText = "Welcome to Mr. Fox's Home Page!";

            return View(model);
        }

        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            //// Manually Retrieve Form Values
            //var email = Request.Form["email"];
            //var age = int.Parse(Request.Form["age"]);

            //ContactModel model = new ContactModel()
            //{
            //    Email = email,
            //    Age = age
            //};

            if (ModelState.IsValid)
            {
                //Do the valid thing
                //return RedirectToAction("Index","HomeController");
                return View("ContactSucces", contact);
            }
            else
            {
                return View();
            }
        }
    }
}