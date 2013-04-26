using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace krabdev.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        {}

        public DbSet<FAQ> FAQs { get; set; }
    }
}