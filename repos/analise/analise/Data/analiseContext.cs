using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using analise.Models;

namespace analise.Data
{
    public class analiseContext : DbContext
    {
        public analiseContext (DbContextOptions<analiseContext> options)
            : base(options)
        {
        }

        public DbSet<analise.Models.Department> Department { get; set; }
    }
}
