namespace QuickRide
{
    public class Rider
    {
        // get/set properties – customer data
        public string Id { get; set; }
        public string Name { get; set; }
        public double XLocation { get; set; }
        public double YLocation { get; set; }
        public double Rating { get; set; }

        // constructor
        public Rider(string id, string name, double xLocation, double yLocation, double rating)
        {
            Id = id;
            Name = name;
            XLocation = xLocation;
            YLocation = yLocation;
            Rating = rating;
        }
    }
}