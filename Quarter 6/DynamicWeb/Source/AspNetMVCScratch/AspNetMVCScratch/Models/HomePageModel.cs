using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVCScratch.Models
{
    public class HomePageModel
    {
        public String Title { get; set; }
        public String Heading { get; set; }
        public String WelcomeMessage { get; set; }
        public List<int> NumberOfTheDay { get; set; }

        public HomePageModel()
        {
            this.NumberOfTheDay = new List<int>();
        }

    }
}