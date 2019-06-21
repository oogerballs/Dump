using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public String ProfileName { get; set; }
        public String NickName { get; set; }
        public List<String> ImageUrlList { get; set; }
        public Dictionary<string, string> Favorites { get; set; }
    }
}
