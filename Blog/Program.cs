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

            //var user = new User()
            //    Name = "Eduardo",
            //    Slug = "eduardoguedes",
            //    Email = "andre@balta.io",
            //    Bio = "9x Microsoft MVP",
            //    Image = "https://balta.io",
            //    PasswordHash = "123098457"
            //};

            //var category = new Category
            //{
            //    Name = "Backend",
            //    Slug = "backend"
            //};

            //var post = new Post
            //{
            //    Author = user,
            //    Category = category,
            //    Body = "<p>Hello world</p>",
            //    Slug = "comecando-com-ef-core",
            //    Summary = "Neste artigo vamos aprender EF core",
            //    Title = "Começando com EF Core",
            //    CreateDate = DateTime.Now,
            //    LastUpdateDate = DateTime.Now,
            //};

            //context.Posts.Add(post); // Não adicionei autor nem categoria
            //context.SaveChanges();


           var posts = context
                 .Posts?
                 .AsNoTracking()
                 .Include(x => x.Author)
                 .Include(x => x.Category)
                 .OrderBy(x => x.LastUpdateDate)
                 .ToList();

            foreach (var post in posts) 
                 Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category?.Name}");

        }

    } 

}