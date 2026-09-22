namespace QuickRide;


/// Selects an available driver for a ride request.

public sealed class DispatchService
{
    private static readonly string[] Drivers =
    {
        "Alex (Prius)",
        "Sam (Civic)",
        "Taylor (Corolla)"
    };

    private readonly IRandom random;

    public DispatchService(IRandom random)
    {
        this.random = random ?? throw new ArgumentNullException(nameof(random));
    }

    public string MatchDriver()
    {
        var driverIndex = random.Next(0, Drivers.Length);
        return Drivers[driverIndex];
    }
}
