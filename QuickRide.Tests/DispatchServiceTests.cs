using Xunit;

namespace QuickRide.Tests;

public class DispatchServiceTests
{
    [Theory]
    [InlineData(0, "Alex (Prius)")]
    [InlineData(1, "Sam (Civic)")]
    [InlineData(2, "Taylor (Corolla)")]
    public void MatchDriver_UsesIndexReturnedByRandom(int randomIndex, string expectedDriver)
    {
        var dispatchService = new DispatchService(new FakeRandom(randomIndex));

        var driver = dispatchService.MatchDriver();

        Assert.Equal(expectedDriver, driver);
    }

    private sealed class FakeRandom : IRandom
    {
        private readonly int nextValue;

        public FakeRandom(int nextValue)
        {
            this.nextValue = nextValue;
        }

        public int Next(int minValue, int maxValue)
        {
            Assert.Equal(0, minValue);
            Assert.Equal(3, maxValue);
            return nextValue;
        }
    }
}
