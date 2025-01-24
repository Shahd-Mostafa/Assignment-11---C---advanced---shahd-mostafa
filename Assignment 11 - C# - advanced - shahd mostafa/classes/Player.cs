using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Player
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public string Name { get; set; }

        public string Team { get; set; }

        public void Run(Location location) =>Console.WriteLine($"{this}Running toward the ball =>{location}");
        public override string ToString()
        {
            return $"Player Name is {Name} in Tram called{Team}";
        }
    }
}
