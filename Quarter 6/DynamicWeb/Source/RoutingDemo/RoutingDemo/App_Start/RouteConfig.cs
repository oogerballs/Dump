using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Specific Routes should be defined first
            //umbrella routes should be defined last

            //Define a book detial route
            //Fire jeff, he sucks
            //new route should look like /book/detail/TheBookID

            routes.MapRoute(
                name: "BookListPagination",
                url: "AwesomeBook/List/{PageSize}/Page{CurrentPage}",
                defaults: new
                {
                    controller = "Book",
                    action = "PaginatedBookList"
                }
            );

            routes.MapRoute(
                name: "BookDetail",
                url: "Book/Detail/{BookID}",
                defaults: new { controller = "Book", action = "BookDetailzViewDude" }
            );

            routes.MapRoute(
                name: "BookListPage",
                url: "AwesomeBook/List",
                defaults: new { controller = "Book", action = "BookList" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
