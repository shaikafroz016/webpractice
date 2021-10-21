using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping_portal1.Models
{
    public class Product
    {
        [Key]
        public int prdid { get; set; }
        public string prdname { get; set; }
        public string prdcatg { get; set; }
        public string description { get; set; }
        public long price { get; set; }
    }
}