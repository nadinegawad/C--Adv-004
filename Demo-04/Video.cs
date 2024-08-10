using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Video
    {
        public string Title { get; set; }
        public string Descripation { get; set; }

        public override string ToString()
        {
            return $"{Title} :: {Descripation}";
        }
    }

}
