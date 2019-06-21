using IxcameyC_Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IxcameyC_Routing.Controllers
{
    public class CowsController : Controller
    {
        // GET: Cows
        public ActionResult CowMoo(CowModel cow)
        {
            return View(cow);
        }

        public ActionResult CowMooDefault(CowModel cow)
        {
            return View(cow);
        }

        public ActionResult SingleGallery(Gallery cow)
        {

            return View(cow);
        }

        public ActionResult AllGallery(Gallery cow)
        {

            return View(cow);
        }

        public ActionResult MultiMoo(MooModel model)
        {
            for(int i = 0;i < model.MooAmount; i++)
            {
                model.MooReturn += "Moo \n";
            }
            return View(model);
        }
    }
}