using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Channel
    {
        public string? ChannelName { get; set; }
        public List<Video> videos { get; set; }=new List<Video>();


        //DELEGATE

        public event Action<Video,Channel>? UploadVideo;
        public void AddVideo(Video video)
        {
            videos.Add(video);
            UploadVideo?.Invoke(video,this);
        }
        public override string ToString()
        {
            return $"Channel name is : {ChannelName}";
        }


    }
}
