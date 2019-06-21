using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSite.Models 
{
    public class Image
    {
        public int ImageId { get; set; }
        public String ImageName { get; set; }
        public String ImgSrc { get; set; }
        public String Caption { get; set; }
        public string Publisher { get; set; }
        public String Comments { get; set; }
        public int ProfileId { get; set; }
        public string Userid { get; set; }
    }
}