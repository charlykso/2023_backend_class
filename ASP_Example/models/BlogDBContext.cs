using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP_Example.models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Blog> blogs { get; set; } = null!;
    }
}