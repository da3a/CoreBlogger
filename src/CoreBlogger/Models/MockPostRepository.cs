using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public class MockPostRepository : IPostRepository
    {
        public IEnumerable<Post> GetByBlogId(int blogId)
        {
            return new List<Post>()
            {
            new Post() { PostId = 1, Title = "First Post", Content = "My First post..." } ,
            new Post() { PostId = 2, Title = "Second Post", Content = "My Second post..." }
            };
        }
    }
}
