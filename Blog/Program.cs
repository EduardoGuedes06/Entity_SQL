using System;
using Blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{

    class program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            context.Users.Add(new User
            {
                Bio = "",
                Email = "",
                Image = "",
                PasswordHash = "",
                Slug = ""
            });
            context.SaveChanges();

            var post = new Post
            {
                Author = null,
                Body = "Meu Artigo",
                Category = null,
                CreateDate = System.DateTime.Now,
                //
            }
        }

    } 

}