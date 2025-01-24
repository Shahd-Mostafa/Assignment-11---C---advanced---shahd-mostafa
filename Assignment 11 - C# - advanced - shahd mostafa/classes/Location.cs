using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal struct Location
    {
        public int x { get; set; }
        public int y { get; set; }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"[{x},{y}]";
        }
    }
}
