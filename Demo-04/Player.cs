using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"Player :{PlayerName} is Runing to {ball}");
        }
    }
}
