using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Refree
    {
        public string RefreeName {  get; set; }

        public void Look(Ball ball)
        {
            Console.WriteLine($"Revree {RefreeName} is looking to {ball}");
        }
    }
}
