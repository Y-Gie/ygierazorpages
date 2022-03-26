#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ygierazorpages.Pages.Music;

namespace ygierazorpages.Data
{
    public class ygierazorpagesContext : DbContext
    {
        public ygierazorpagesContext (DbContextOptions<ygierazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<ygierazorpages.Pages.Music.Music> Music { get; set; }
    }
}
