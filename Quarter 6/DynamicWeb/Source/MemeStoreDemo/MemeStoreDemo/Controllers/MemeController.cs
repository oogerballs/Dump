using MemeStoreService.Models;
using MemeStoreService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MemeStoreDemo.Controllers
{
    public class MemeController : Controller
    {
        IMemeStoreServicecs service = new EFMemeStoreService();
        // GET: Meme
        public ActionResult MemeList()
        {
            var model = service.GetAllMemes();

            return View(model);
        } 

        public ActionResult MemeDetail(int id)
        {
            var model = service.GetMemeById(id);
            return View(model);
        }
        [Authorize(Roles ="Admin, User")]
        public RedirectToRouteResult Delete(int id)
        {
            var theMeme = service.GetMemeById(id);
            if(!User.IsInRole("Admin") || theMeme.userId != User.Identity)
            {
                //Punish cheeky cunt
            }
            service.GetMemeById(id);
            return RedirectToAction("MemeList");
        }

        [HttpGet]
        public ViewResult CreateMeme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMeme(MemeModel model)
        {
            //We should get a populated MemeModel because model binding rocks!

            //use our meme service to create the meme.
            service.CreateMeme(model);

            //Redirect user to the meme detail for the new meme? 

            return RedirectToAction("MemeDetail", "Meme", new { });
        }
    }
}