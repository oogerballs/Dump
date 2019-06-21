using AspNetMVCScratch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //Business Logic
            //fetching records from a DB
            //Setting up a view model
            //Passing the View Model to the View to generate HTML


            //Return something to the user

            HomePageModel model = new HomePageModel();

            model.Title = "My Demo homepage";
            model.Heading = "My homepage heading";
            model.WelcomeMessage = "Welcocme to my first ASP.Net MVC site!";
            model.NumberOfTheDay = new List<int>() { 1, 22, 44, 2424 };


            return View(model);
        }
    }
}