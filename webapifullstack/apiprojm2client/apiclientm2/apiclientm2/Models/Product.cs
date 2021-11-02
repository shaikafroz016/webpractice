using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiclientm2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string prd_name { get; set; }
        public string prd_catg { get; set; }

        public int price { get; set; }

        public string desc { get; set; }
    }
}