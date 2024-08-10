using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Subscriber
    {
        public string name {  get; set; }

        public void notify(Video video, Channel channel)
        {
            Console.WriteLine($"{name},{channel} added A new Video\n{video}");
        }

        
    }
}
