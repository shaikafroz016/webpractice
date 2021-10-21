using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webmvcfullstack.Models
{
    public class emp
    {
        [Key]
        public int empno { get; set; }
        public string empname { get; set; }
        public string  job { get; set; }
        public int deptno { get; set; }
        public int salary { get; set; }
    }
}
