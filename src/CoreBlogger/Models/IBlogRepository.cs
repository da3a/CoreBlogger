using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> Blogs { get; }

        Blog GetById(int blogId);
    }
}
