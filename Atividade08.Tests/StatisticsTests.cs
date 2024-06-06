using System;
using System.Collections.Generic;
using Xunit;
using Atividade08;

namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_NullList_ShouldThrowArgumentException()
        {
            // Arrange
            var stats = new Statistics();

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => stats.CalculateAverage(null));
            Assert.Equal("The list of numbers cannot be empty", exception.Message);
        }

        [Fact]
        public void CalculateAverage_EmptyList_ShouldThrowArgumentException()
        {
            // Arrange
            var stats = new Statistics();
            var numbers = new List<int>();

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => stats.CalculateAverage(numbers));
            Assert.Equal("The list of numbers cannot be empty", exception.Message);
        }

        [Fact]
        public void CalculateAverage_ValidList_ShouldReturnCorrectAverage()
        {
            // Arrange
            var stats = new Statistics();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            var result = stats.CalculateAverage(numbers);

            // Assert
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void CalculateAverage_SingleElementList_ShouldReturnElementValue()
        {
            // Arrange
            var stats = new Statistics();
            var numbers = new List<int> { 5 };

            // Act
            var result = stats.CalculateAverage(numbers);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void CalculateAverage_NegativeNumbers_ShouldReturnCorrectAverage()
        {
            // Arrange
            var stats = new Statistics();
            var numbers = new List<int> { -1, -2, -3, -4, -5 };

            // Act
            var result = stats.CalculateAverage(numbers);

            // Assert
            Assert.Equal(-3.0, result);
        }
    }
}
