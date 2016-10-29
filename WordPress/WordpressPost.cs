using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordPress
{
    public class WordPressPost : WordPressPage
    {
        public List<string> tags;
        public List<string> categories;

        enum Format
        {
            Standard,
            Aside,
            Image,
            Video,
            Quote,
            Link
        }
        Format format;

        string featuredImage; 

    }
}
