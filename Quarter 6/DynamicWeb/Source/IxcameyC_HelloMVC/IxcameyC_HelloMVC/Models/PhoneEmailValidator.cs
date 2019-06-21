using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IxcameyC_HelloMVC.Models
{
    public class PhoneEmailValidator : ValidationAttribute
    {


        private string GetErrorMessage()
        {

            return "Ether the Phone Number field or the Email field must be filled out.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            FormModel f = (FormModel)validationContext.ObjectInstance;

            if (f.Email == null && f.PhoneNumber == null)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}