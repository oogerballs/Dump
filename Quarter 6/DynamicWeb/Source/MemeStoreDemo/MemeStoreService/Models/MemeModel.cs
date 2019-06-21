using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Models
{
    public class MemeModel
    {
        public int MemeId { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public string ImageUrl { get; set; }
        public string userId { get; set; }
    }
}
