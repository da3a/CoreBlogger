using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetByBlogId(int blogId);

    }
}
