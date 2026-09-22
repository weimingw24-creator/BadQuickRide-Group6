namespace QuickRide
{
    public class Driver
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double XLocation { get; set; }
        public double YLocation { get; set; }
        public double Rating { get; set; }
        public bool IsAvailable { get; set; }

        public Driver(string id, string name, double xLocation, double yLocation, double rating, bool isAvailable = true)
        {
            Id = id;
            Name = name;
            XLocation = xLocation;
            YLocation = yLocation;
            Rating = rating;
            IsAvailable = isAvailable;
        }
    }
}