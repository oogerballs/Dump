using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Models
{
    public class CommentModel
    {
        public int CommentId { get; set; }
        public int MemeId { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
