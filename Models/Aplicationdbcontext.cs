using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirstapproach.Models
{
    public class Aplicationdbcontext:DbContext
    {
        public Aplicationdbcontext() : 
            base("Data Source=CHETUIWK222;Initial Catalog=codee;Integrated Security=True;Pooling=False") { }
        public DbSet<emp> emps { get; set; }
    }
}