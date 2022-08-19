using System;
using Blog.Models;
using Blog.Data;

namespace Blog
{

    class program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                //var tag = new Tag { Name = "Ast.Net", Slug = "Aspnet.core" };
                //context.Tags.Add(tag);
                //context.SaveChanges();
                var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
                tag.Name = "DotNet";
                tag.Slug = "dotnet.json";

                context.Update(tag);
                context.SaveChanges();
            }
        }


    }



}