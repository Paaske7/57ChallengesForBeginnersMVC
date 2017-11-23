using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
    }
}