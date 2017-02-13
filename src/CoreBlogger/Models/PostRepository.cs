using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public class PostRepository : IPostRepository
    {

        private readonly CoreBloggerContext context;

        public IEnumerable<Post> GetByBlogId(int blogId)
        {
            return context.Posts.Where(x => x.BlogId == blogId);
        }
    }
}
