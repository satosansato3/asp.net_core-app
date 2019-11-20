using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ms_learn.Models
{
    public class ms_learnContext : DbContext
    {
        public ms_learnContext (DbContextOptions<ms_learnContext> options)
            : base(options)
        {
        }

        public DbSet<ms_learn.Models.Product> Product { get; set; }
    }
}
