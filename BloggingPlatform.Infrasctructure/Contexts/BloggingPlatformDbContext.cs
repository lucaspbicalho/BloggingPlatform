using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BloggingPlatform.Infrasctructure.Contexts
{
    public class BloggingPlatformDbContext : DbContext
    {
        public BloggingPlatformDbContext(DbContextOptions<BloggingPlatformDbContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
