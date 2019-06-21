using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Models
{
    public class ProfileModel
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public List<string> Favorites { get; set; }
    }
}
