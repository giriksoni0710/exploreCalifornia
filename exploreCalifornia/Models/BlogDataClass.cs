using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreCalifornia.Models
{
    public class BlogDataClass : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogDataClass(DbContextOptions<BlogDataClass> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
