using MemeStoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeStoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(MemeListModel Model)
        {
            Model.Memes.Add(new MemeModel()
            {
                Name = "Ermagherd",
                ImageUrl = "http://res.cloudinary.com/sagacity/image/upload/c_crop,h_800,w_616,x_0,y_0/c_scale,w_640/v1419879339/iVegJ35_xfjlfu.gif",
                IsDead = true,
                MemeId = 1

            });
            return View(Model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}