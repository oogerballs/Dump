using Microsoft.AspNet.Identity;
using SocialMediaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialMediaSite.Controllers
{
    public class HomeController : Controller
    {
        ISocialMediaService service = new EFSocialMediaService();
        public ActionResult Index()
        {
            var model = service.GetNewsFeed(5);
            return View(model);
        }

        public ActionResult Profile(String id)
        {
            if(id == "" || id == null)
            {
                return RedirectToAction("Index", "Home", new { });
            }
            var model = service.GetProfile(id);
            return View(model);
        }

        public  ActionResult Imagedetail(int id)
        {
            var model = service.GetImageById(id);
            return View(model);
        }

        public ActionResult Gallery(string id)
        {
            int PId = service.GetProfile(id).Id;
            var model = service.GetGalleryList(PId);
            return View(model);
        }

        public ProfileModel CreateUser()
        {
            Dictionary<string, string> favs = new Dictionary<string, string>
            {
                { "Book", "The Silent Girls" },
                { "Game", "Left 4 Dead 2" },
                { "Movie", "Logan" }
            };
            ProfileModel profile = new ProfileModel()
            {
                Id = 1,
                ProfileName = "Cristian Ixcamey",
                NickName = "ooger",
                ProfileImageUrl = "https://images.pexels.com/users/avatars/424770/cristian-ixcamey-347.jpeg?w=256&h=256&fit=crop&crop=faces",

            };
            return profile;
        }
        public RedirectToRouteResult Delete(int id)
        {
            var image = service.GetImageById(id);
            if (image.Publisher != User.Identity.Name)
            {
                RedirectToAction("Imagedetail/" + id, "Home");
            }
            else {
            service.DeleteImageById(id);
            }
            return RedirectToAction("Gallery");
        }

        [HttpGet]
        public ViewResult CreateImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateImage(Models.Image model)
        {
            var profile = service.GetProfile(User.Identity.GetUserName());
            model.Publisher = profile.NickName;
            model.ProfileId = profile.Id;
            model.Userid = User.Identity.GetUserId();
            service.CreateImage(model);
            return RedirectToAction("Gallery/"+User.Identity.GetUserName(), "Home", new { });
        }

        [HttpGet]
        public ViewResult UpdateImage(int id)
        {
            // Pass in the id for the Image to update\
            var model = service.GetImageById(id);

            // Fetch the Model we want to update and pass it to the view
            return View(model);
        }

        [HttpPost]
        public ActionResult updateImage(Models.Image model)
        {
            service.UpdateImage(model);
            return RedirectToAction("Gallery","home");
        }
    }
}