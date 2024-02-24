using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMovil1.Models;

namespace RazorPageMovil1.Data
{
    public class RazorPageMovil1Context : DbContext
    {
        public RazorPageMovil1Context (DbContextOptions<RazorPageMovil1Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMovil1.Models.Movie> Movie { get; set; } = default!;
    }
}
