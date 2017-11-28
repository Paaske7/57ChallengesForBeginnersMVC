using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_7.Models
{
    public class Propertiess
    {
        [Required(ErrorMessage = "Enter the length")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Enter the width")]
        public int Width { get; set; }

        public int SquareFeet { get; set; }


        public int SquareMeters { get; set; }
    }
}