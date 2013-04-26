using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace krabdev.Models
{
    public class FAQ
    {
        [Key]
        public int FAQId { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Anwser { get; set; }
    }
}