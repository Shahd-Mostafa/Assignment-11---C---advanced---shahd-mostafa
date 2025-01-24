using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal static class IntExtenstions
    {
        public static bool IsInRange(this int value,int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
