using IxcameyC_HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IxcameyC_HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FormModel formInfo)
        {
            if (ModelState.IsValid)
            {
                if (formInfo.Age < 18)
                {
                    formInfo.Message = "Your parents";
                }
                else
                {
                    formInfo.Message = "You";
                }

                if (formInfo.Email != null && formInfo.PhoneNumber != null)
                {
                    formInfo.Message += " will be contact VIA Phone and Email";
                }
                else if (formInfo.PhoneNumber != null)
                {
                    formInfo.Message += " will be contact VIA Phone";
                }
                else if(formInfo.Email != null)
                {
                    formInfo.Message += " will be contact VIA Email";
                }
                return View("GreetingPage", formInfo);
            }
            else
            {
            return View();
            }
        }


        public ActionResult GreetingPage(FormModel formInfo)
        {
            if (formInfo.Age < 18)
            {
                formInfo.Message = "Your parents";
            }
            else
            {
                formInfo.Message = "You";
            }

            if (formInfo.Email != null || formInfo.Email != "")
            {
                formInfo.Message += " will be contact VIA Email";
            }else if(formInfo.PhoneNumber != null)
            {
                formInfo.Message += " will be contact VIA Phone";
            }
            else
            {
                formInfo.Message += " will be contact VIA Phone and Email";
            }

            return View(formInfo);
        }
    }
}