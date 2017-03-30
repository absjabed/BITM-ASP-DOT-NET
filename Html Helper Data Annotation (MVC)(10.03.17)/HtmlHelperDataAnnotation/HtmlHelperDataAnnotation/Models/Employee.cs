using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelperDataAnnotation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Your NAme must be 5-10 cahrecter long")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage = "Please Provide a Valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Select your gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter your Department")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Please Enter your password")]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-Enter your password")]
        [StringLength(10, MinimumLength = 6)]
       // [Compare("Password", ErrorMessage = "Password doesn't match")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}