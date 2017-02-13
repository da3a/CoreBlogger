﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogger.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }

        public string Owner { get; set;}

        public virtual List<Post> Posts { get; set; }

    }
}
