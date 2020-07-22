using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
