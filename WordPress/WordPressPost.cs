﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
    public class WordPressPost : WordPressPage
    {

        public static int postCount = 0;

        public List<string> tag;
        public List<string> category;

        public enum Format
        {
            Standard,
            Aside,
            Image,
            Video,
            Quote,
            Link
        }

        public Format _format;
        public string shortLink;

        public WordPressPost() : base()
        {
            postCount++;
            id = postCount;
        }
    }
}
