using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.Youtoube
{
    public  class Channel
    {
        public string  ChannelName {  get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();
        public void addvideo(Video video)
        {
           Videos.Add(video);

            // notify subcriber 
            Uploadvideo?.Invoke(video,this); 

    }
    public event Action<Video,Channel>? Uploadvideo;
        public override string ToString()
        {
            return $" Channel name {ChannelName} "; 
        }

    }
}
