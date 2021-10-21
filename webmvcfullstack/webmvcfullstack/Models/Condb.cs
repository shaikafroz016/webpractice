using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvcfullstack.Models
{
    public class Condb : DbContext
    {
        public Condb(DbContextOptions<Condb> options
            ) : base(options)
        {

        }
        public DbSet<emp> emps { get; set; }
    }
    
    }

