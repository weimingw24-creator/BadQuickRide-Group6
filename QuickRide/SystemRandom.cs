namespace QuickRide;

/// <summary>
/// Production adapter for <see cref="System.Random"/>.
/// </summary>
public sealed class SystemRandom : IRandom
{
    private readonly Random random = new();

    public int Next(int minValue, int maxValue) => random.Next(minValue, maxValue);
}
