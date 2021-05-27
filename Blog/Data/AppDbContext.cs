using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) 
            :base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
