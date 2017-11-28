using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_8.Models
{
    public class Propss
    {
        [Required(ErrorMessage = "Enter how many people you are")]
        public int People { get; set; }

        [Required(ErrorMessage = "Enter how many pizzas you have")]
        public int Pizza { get; set; }

        public int left { get; set; }

        public int each { get; set; }

    }
}