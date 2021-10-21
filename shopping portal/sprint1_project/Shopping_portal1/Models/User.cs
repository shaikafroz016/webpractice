using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping_portal1.Models
{
    public class User
    {
        [Key]
        [Required]
        public int userid { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string first_name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string last_name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9\s]*$")]
        public string username { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string password { get; set; }
        [Required]
        public string gender { get; set; }
        public bool isadmin { get; set; }
        public string address { get; set; }
        
        public string email { get; set; }
        public long mobile { get; set; }
    }
}