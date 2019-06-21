using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IxcameyC_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region GalleryNoAmount
            routes.MapRoute(
                   name: "GalleryNoAmount",
                   url: "AllCows/Gallery/Page{PageNo}",
                   defaults: new
                   {
                       controller = "Cows",
                       action = "AllGallery",
                       Amount = 5,
                       PageNo = 1
                   }
               );
            #endregion

            #region GalleryWPage
            routes.MapRoute(
                    name: "GalleryWPage",
                    url: "AllCows/Gallery/{Amount}/page{PageNo}",
                    defaults: new
                    {
                        controller = "Cows",
                        action = "AllGallery",
                        Amount = 5,
                        PageNo = 1
                    }
                );
            #endregion

            #region Gallery
            routes.MapRoute(
                    name: "Gallery",
                    url: "AllCows/Gallery/{Amount}/{PageNo}",
                    defaults: new
                    {
                        controller = "Cows",
                        action = "AllGallery",
                        Amount = 5,
                        PageNo = 1
                    }
                );
            #endregion
                     
            #region SingleGalleyr
            routes.MapRoute(
                    name: "singleGallery",
                    url: "{SlcCow}/Gallery/",
                    defaults: new
                    {
                        controller = "Cows",
                        action = "SingleGallery",
                        SlcCow = "Default"
                    }
                );
            #endregion

            #region AboutUs
            routes.MapRoute(
                   name: "AboutUs",
                   url: "Moo",
                   defaults: new
                   {
                       controller = "Home",
                       action = "AboutUs",
                       id = UrlParameter.Optional
                   }
               );
            #endregion

            #region MultipleMoo
            routes.MapRoute(
                 name: "MultiMoo",
                 url: "moo{MooAmount}",
                 defaults: new
                 {
                     controller = "Cows",
                     action = "MultiMoo",
                     MooAmount = 1
                 }
             );
            #endregion

            #region MoreChikin
            routes.MapRoute(
                  name: "Morechikin",
                  url: "EatMoreChicken",
                  defaults: new
                  {
                      controller = "Home",
                      action = "MoreChikin",
                      id = UrlParameter.Optional
                  }
              );
            #endregion

            #region Home
            routes.MapRoute(
                    name: "Home",
                    url: "Home/Index",
                    defaults: new
                    {
                        controller = "Home",
                        action = "Index"
                    }
                );
            #endregion

            #region MooPage
            routes.MapRoute(
                    name: "MooPage",
                    url: "{MooCount}/{Name}",
                    defaults: new
                    {
                        controller = "Cows",
                        action = "CowMoo"
                    }
                );
            #endregion

            #region MooPageDefault
            routes.MapRoute(
                    name: "MooPageDefault",
                    url: "{MooCount}",
                    defaults: new
                    {
                        controller = "Cows",
                        action = "CowMooDefault"
                    }
                );
            #endregion

            #region Default
            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new
                    {
                        controller = "Home",
                        action = "Index",
                        id = UrlParameter.Optional
                    }
                ); 
            #endregion

        }
    }
}
