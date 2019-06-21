using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSite.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public String ProfileName { get; set; }
        public String NickName { get; set; }
        public string ProfileImageUrl { get; set; }
        public List<Favorite> Favorite { get; set; }
    }
}
