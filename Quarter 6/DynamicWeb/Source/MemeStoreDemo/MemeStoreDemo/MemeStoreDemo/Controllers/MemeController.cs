using MemeStoreService.Models;
using MemeStoreService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeStoreDemo.Controllers
{
    public class MemeController : Controller
    {
        IMemeStoreService service = new EFMemeStoreService();

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

        public RedirectToRouteResult Delete(int id)
        {
            service.DeleteMemeById(id);

            return RedirectToAction("MemeList");
            //return View("MemeList");
        }

        [HttpGet]
        public ViewResult CreateMeme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMeme(MemeModel model)
        {
            // We should get a populated MemeModel because Model Binding Rocks!

            // Use our Meme Service to create the Meme.
            service.CreateMeme(model);

            // Redirect user to the Meme Detail for the new meme?

            return RedirectToAction("MemeDetail", "Meme", new { id = model.MemeId });
        }

        [HttpGet]
        public ViewResult AddComment(int id)
        {
            var model = service.GetMemeById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            // Which userid to set on the comment?!?!?!?
            var currentUserName = User.Identity.Name;
            var userId = service.GetUserIdByUserName(currentUserName);
            comment.UserId = userId;

            service.AddComment(comment);

            return RedirectToAction("MemeDetail", "Meme", new { id = comment.MemeId });
        }
    }
}