using System;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    class LocationEventArgs: EventArgs
    {
        public Location NewLocation { get; set; }
        public string Name { get; set; }
    }
    internal class Ball
    {
        public Ball() { }
        public int Id { get; set; }

        public Ball(int id, Location location)
        {
            Id = id;
            Location = location;
        }
        public string Name { get; set; }
        Location location;
        public Location Location
        {
            get => location;
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    LocationChange?.Invoke(this,new LocationEventArgs {NewLocation=Location ,Name=Name});
                }
            }
        }

        //public event Action<Location> LocationChange;
        public event EventHandler<LocationEventArgs> LocationChange;
        public override string ToString()
        {
            return $"Ball with Id = {Id} is now at {location}";
        }
    }
}
