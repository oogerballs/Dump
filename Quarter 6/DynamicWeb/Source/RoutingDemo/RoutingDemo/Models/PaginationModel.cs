using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutingDemo.Models
{
    public class PaginationModel
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}