using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Models
{
    public class MemeListModel
    {
        public List<MemeModel> Memes { get; set; }

        public MemeListModel()
        {
            Memes = new List<MemeModel>();
        }
    }
}
