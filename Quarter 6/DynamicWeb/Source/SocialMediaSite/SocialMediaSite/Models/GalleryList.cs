using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSite.Models
{
    public class GalleryList
    {
        public List<Image> Images { get; set; }

        public GalleryList()
        {
            Images = new List<Image>();
        }
    }
}