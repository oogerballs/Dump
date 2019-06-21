using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSite.Models
{
    public class GalleryImageModel
    {
        public int ImageId { get; set; }
        public String ImageName { get; set; }
        public String ImgSrc { get; set; }
        public String Caption { get; set; }
        public string Publisher { get; set; }
    }
}