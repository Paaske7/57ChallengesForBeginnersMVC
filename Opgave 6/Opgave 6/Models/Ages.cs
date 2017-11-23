using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_6.Models
{
    public class Ages
    {
        [Required(ErrorMessage = "Enter your age")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Enter what age you want to retire")]
        public int RetireAge { get; set; }

        public int left { get; set; }

        public DateTime dt { get; set; }

        public DateTime dt2 { get; set; }

    }
}