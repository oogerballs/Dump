using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetMVCIntro.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="this is a different error message")]
        public String Email { get; set; }
        [Range( 5,140), Required()]
        public int Age { get; set; }

    }
}