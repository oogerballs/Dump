using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IxcameyC_HelloMVC.Models
{
    public class FormModel
    {
        [Required(ErrorMessage ="Please enter a valid First Name")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a valid Last Name")]
        public String LastName { get; set; }
        [PhoneEmailValidator]
        [Phone]
        public String PhoneNumber { get; set; }
        [EmailAddress]
        [PhoneEmailValidator]
        public String Email { get; set; }
        [Range(5, 140), Required(ErrorMessage ="Age must be greater than 5")]
        public int Age { get; set; }
        public String Message { get; set; }
    }
}