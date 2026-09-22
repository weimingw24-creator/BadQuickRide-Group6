namespace QuickRide;

/// <summary>
/// Provides random-number generation that can be replaced in tests.
/// </summary>
public interface IRandom
{
    int Next(int minValue, int maxValue);
}
