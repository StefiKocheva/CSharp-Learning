using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMvcApp.Data
{
    public class BlogPosts
    {
        public int id { get; set; }

        public IdentityUser MyProperty { get; set; }

        public string UserId { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BlogPosts> Posts { get; set; } 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
