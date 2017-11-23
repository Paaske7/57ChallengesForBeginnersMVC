using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_5.Models
{
    public class Numbers
    {
        [Required(ErrorMessage = "Enter the first number")]
        public int Number1 { get; set; }


        [Required(ErrorMessage = "Enter the second number")]
        public int Number2 { get; set; }


        public int result1 { get; set; }

        public int result2 { get; set; }

        public int result3 { get; set; }

        public int result4 { get; set; }



    }
}