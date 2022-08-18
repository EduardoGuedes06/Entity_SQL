using Microsoft.EntityFrameworkCore;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    internal class BlogDataContext : DbContext
    {


        public DbSet<Category> ? Categories { get; set; }
        public DbSet<Post> ? Posts { get; set; }
        //public DbSet<PostTag> ? PostTags { get; set; }
        public DbSet<Role> ? Roles { get; set; }
        public DbSet<Tag> ? Tags { get; set; }
        public DbSet<User> ? Users { get; set; }
        //public DbSet<UserRole> ? UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False");
    }

}

