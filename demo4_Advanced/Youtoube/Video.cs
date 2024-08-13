using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.Youtoube
{
    public class Video
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Title : {Title},description {Description}";
        }

    }
}
