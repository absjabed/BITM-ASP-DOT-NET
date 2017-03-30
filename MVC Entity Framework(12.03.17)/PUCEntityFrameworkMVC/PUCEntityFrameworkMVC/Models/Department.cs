using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PUCEntityFrameworkMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Depertment Code is required!")]
        [DisplayName("Department Code")]
        [StringLength(7, MinimumLength = 2, ErrorMessage = "Depertment Code must be 2~7 charecter long.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Depertment Name is required!")]
        [DisplayName("Department Name")]
        public string Name { get; set; }

    }
}