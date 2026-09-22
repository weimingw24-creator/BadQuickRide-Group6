using Xunit;
using QuickRide;

namespace QuickRide.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateFare_StandardDistance_ReturnsCorrectTotal()
        {
            // Arrange
            double distance = 10.0;
            bool isPeak = false;
            double expectedFare = 15.00; // $2.50 + (10 * $1.25)

            // Act
            double actualFare = Program.CalculateFare(distance, isPeak);

            // Assert
            Assert.Equal(expectedFare, actualFare);
        }
    }
}
