using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public class MockBlogRepository : IBlogRepository
    {
        public IEnumerable<Blog> Blogs
        {
            get
            {
                return new List<Blog>
                {
                    new Blog()
                    {
                        BlogId =1,
                        Owner ="David",
                        Title = "David's Blog",
                        Posts =new List<Post>()
                        {
                        new Post() { PostId = 1, Title = "First Post", Content = "My First post..." } ,
                        new Post() { PostId = 2, Title = "Second Post", Content = "My Second post..." }
                        }
                    },
                    new Blog()
                    {
                        BlogId = 2,
                        Owner = "Emily",
                        Title = "Emiily's Blog",
                        Posts = new List<Post>()
                        {
                            new Post() { PostId = 1, Title = "First Post", Content = "My First post..." } ,
                            new Post() { PostId = 2, Title = "Second Post", Content = "My Second post..." }
                        }
                    }
                };
            }
        }

        public Blog GetById(int blogId)
        {
            return new Blog()
            {
                BlogId = 1,
                Owner = "David",
                Title = "David's Blog",
                Posts = new List<Post>()
                        {
                        new Post() { PostId = 1, Title = "First Post", Content = "My First post..." } ,
                        new Post() { PostId = 2, Title = "Second Post", Content = "My Second post..." }
                        }
            };
        }
    }
}
