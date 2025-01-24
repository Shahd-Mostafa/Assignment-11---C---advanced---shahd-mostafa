using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Refree
    {
        public string Name { get; set; }
        public Refree(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Refree Name {Name}";
        }
        public void Look(object sender, LocationEventArgs locationEventArgs) => Console.WriteLine($"{this} is looking toward the ball => {sender} , {locationEventArgs.NewLocation}");
    }
}
