using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_2.Models
{
    public class Word
    {
        [Required(ErrorMessage = "Please enter a string")]
        public string input { get; set; }
    }
    
}