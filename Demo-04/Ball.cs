using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    internal class Ball
    {
        public int Id { get; set; }

        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if (!location.Equals(value)){
                    location = value;
                    BallLocationChange.Invoke(this);
                }
            }

            
        }

        public event Action<Ball>? BallLocationChange;
        public override string ToString()
        {
            return $"Id: {Id} :: Location:{location}";
        }

    }
}
