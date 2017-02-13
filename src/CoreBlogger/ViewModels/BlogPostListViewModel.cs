using CoreBlogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.ViewModels
{
    public class BlogPostListViewModel
    {
        public BlogPostListViewModel Blog { get; set; }

        List<Post> Posts { get; set; }
    }
}
