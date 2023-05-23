using AlbiBlogu.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlbiBlogu.Data
{
    public class ABDbContext : DbContext
    {
        public ABDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
