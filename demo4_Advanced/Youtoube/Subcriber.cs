using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.Youtoube
{
    public class Subcriber
    {
        public string SubcriberName { get; set; }

        public void notify(Video video, Channel channel)
        {
            Console.WriteLine($"New video {video} , by {channel}  Has been added {SubcriberName} "); 


        }
        public override string ToString()
        {
            return $"SubcriberName : {SubcriberName} "; 
        }
    }

}
