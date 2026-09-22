using Xunit;
using QuickRide;

namespace QuickRide.Tests
{
    public class SampleUnitTest
    {
        [Fact]
        public void CalculateFare_StandardDistance_ReturnsCorrectTotal()
        {
            // Arrange
            double distance = 10.0;
            bool isPeak = false;
            double expectedFare = 15.00;

            // Act
            double actualFare = Program.CalculateFare(distance, isPeak);

            // Assert
            Assert.Equal(expectedFare, actualFare);
        }

        [Fact]
        public void CalculateFare_PeakHour_ReturnsSurgedTotal()
        {
            // Arrange
            double distance = 10.0;
            bool isPeak = true;
            double expectedFare = 18.00;

            // Act
            double actualFare = Program.CalculateFare(distance, isPeak);

            // Assert
            Assert.Equal(expectedFare, actualFare);
        }

        [Fact]
        public void CalculateFare_ZeroDistance_ReturnsBaseFare()
        {
            // Arrange
            double distance = 0.0;
            bool isPeak = false;
            double expectedFare = 2.50;

            // Act
            double actualFare = Program.CalculateFare(distance, isPeak);

            // Assert
            Assert.Equal(expectedFare, actualFare);
        }
    }
}