using System;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Ball
    {
        public int Id { get; set; }
        public Location location { get; set; }

        public Ball(int id, Location location)
        {
            Id = id;
            this.location = location;
        }

        public Location Location
        {
            get => location;
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    LocationChange?.Invoke(location);
                }
            }
        }

        public event Action<Location> LocationChange;

        public override string ToString()
        {
            return $"Ball with Id = {Id} is now at {location}";
        }
    }
}
