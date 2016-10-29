using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
    public class WordPressComment : IPublish
    {
        private bool _isPublished;


        public bool isPublished { get; }
        public void publish()
        {
            _isPublished = true;
        }

        public void unpublish()
        {
            _isPublished = false;
        }
    }
}
