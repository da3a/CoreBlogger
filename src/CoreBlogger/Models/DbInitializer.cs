﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public class DbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
           CoreBloggerContext context = applicationBuilder.ApplicationServices.GetRequiredService<CoreBloggerContext>();

            if (!context.Blogs.Any())
            {
                context.AddRange(
                     new Blog()
                     {
                         Owner = "David",
                         Title = "David's Blog",
                         Posts = new List<Post>()
                        {
                        new Post() {  Title = "First Post", Content = "My First post..." } ,
                        new Post() {  Title = "Second Post", Content = "My Second post..." }
                        }
                     },
                    new Blog()
                    {
                        Owner = "Emily",
                        Title = "Emiily's Blog",
                        Posts = new List<Post>()
                        {
                            new Post() {  Title = "First Post", Content = "My First post..." } ,
                            new Post() {  Title = "Second Post", Content = "My Second post..." }
                        }
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
