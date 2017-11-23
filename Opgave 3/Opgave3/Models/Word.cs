using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave3.Models
{
    public class Word
    {
        [Required(ErrorMessage = "Enter quote")]
        public string Quote { get; set; }

        [Required(ErrorMessage = "Enter author")]
        public string Author { get; set; }
    }
}