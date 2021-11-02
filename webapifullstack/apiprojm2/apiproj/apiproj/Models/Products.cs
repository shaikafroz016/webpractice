using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiproj.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string prd_name { get; set; }
        public string prd_catg { get; set; }
        
        public int price { get; set; }       

        public string desc { get; set; }
       
    }
}