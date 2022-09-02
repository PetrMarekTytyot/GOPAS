using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        
        [Required]
        public string Text { get; set; }
        public bool Done { get; set; }
    }
}