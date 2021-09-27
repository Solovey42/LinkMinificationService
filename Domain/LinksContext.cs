using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LinksContext : DbContext
    {
        public DbSet<Link> Links { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=LinksDatabase.db");
        }
        public LinksContext(DbContextOptions<LinksContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
