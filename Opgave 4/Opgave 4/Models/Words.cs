using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opgave_4.Models
{
    public class Words
    {
        [Required(ErrorMessage = "Enter Noun")]
        public string Noun { get; set; }


        [Required(ErrorMessage = "Enter Verb")]
        public string Verb { get; set; }

        
        [Required(ErrorMessage = "Enter Adjective")]
        public string Adjective { get; set; }


        [Required(ErrorMessage = "Enter Adverb")]
        public string Adverb { get; set; }
    }
}