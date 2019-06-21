using ActionResultDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace ActionResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        static CharacterMod CharacterModel = new CharacterMod
        {
            Name = "Karen, Kid Stealer",
            HealthPoints = 100,
            Level = 50
        };
        public ActionResult Index()
        {
            return View(CharacterModel);
        }

        public String Plain()
        {
            return CharacterModel.ToString();
        }

        public ActionResult Missing()
        {
            return HttpNotFound();
        }

        public JsonResult Json()
        {

            JsonResult res = Json(CharacterModel, JsonRequestBehavior.AllowGet);
            return res;
        }

        public ContentResult XML()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(CharacterMod));
            string xmlString = "";
            ContentResult result = new ContentResult();

            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    serializer.WriteObject(writer, CharacterModel);
                    writer.Flush();
                    xmlString = sw.ToString();
                    result = Content(xmlString, "text/xml");
                }
            }

            return result;
        }

        public FileResult Download()
        {

            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/images/b1bc62ac9fd5c095758490f659674871e8bac0d5_hq.jpg"));
            return File(fileBytes, "image/jpeg");
        }
    }
}