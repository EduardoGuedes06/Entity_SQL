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
        }

    } 

}