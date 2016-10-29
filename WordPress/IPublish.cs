using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
    interface IPublish
    {
        bool isPublished { get; }

        void publish();
        void unpublish();

    }
}
