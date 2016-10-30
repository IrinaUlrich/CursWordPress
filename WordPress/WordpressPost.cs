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
        string featuredImage;

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

        public static int postCount=0;

        public WordPressPost() : base()
        {
            postCount++;
            id = postCount;
        }

    }
}
