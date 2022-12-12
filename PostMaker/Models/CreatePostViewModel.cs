using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostMaker.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
       
    }
}
