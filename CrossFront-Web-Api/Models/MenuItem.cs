using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossFront_Web_Api.Models
{
    public class MenuItem
    {
        [Required]
        [Key]
        public int id { get; set; }
        public string text { get; set; }
        public string url { get; set; }
        public bool active { get; set; }


    }
}