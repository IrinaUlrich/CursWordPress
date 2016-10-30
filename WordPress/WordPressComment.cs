using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
   public class WordPressComment : IPublish
    {
        private bool _IsPublished;

        public bool isPublished { get; }
    
        public void publish()
        {
            _IsPublished = true; 
        }

        public void unpublish()
        {
            _IsPublished = false;
        }
    }
}
