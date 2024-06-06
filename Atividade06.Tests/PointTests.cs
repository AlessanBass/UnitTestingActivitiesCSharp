using Xunit;
using Atividade06;

namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void Constructor_ShouldInitializeCoordinates()
        {
            // Arrange
            double x = 3.0;
            double y = 4.0;

            // Act
            var point = new Point(x, y);

            // Assert
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceTo_ShouldReturnCorrectDistance()
        {
            // Arrange
            var point1 = new Point(0, 0);
            var point2 = new Point(3, 4);

            // Act
            double distance = point1.DistanceTo(point2);

            // Assert
            Assert.Equal(5.0, distance);
        }

        [Fact]
        public void DistanceTo_NullArgument_ShouldThrowArgumentNullException()
        {
            // Arrange
            var point = new Point(0, 0);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => point.DistanceTo(null));
        }
    }
}
