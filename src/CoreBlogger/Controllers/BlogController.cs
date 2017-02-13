using CoreBlogger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Controllers
{
    public class BlogController: Controller
    {
        IBlogRepository blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;

        }


       public ViewResult List()
        {
            return View(blogRepository.Blogs);
        }
    }
}
