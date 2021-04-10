using NUnit.Framework;
using CodeSamplesForAssertion;

namespace NUnitAssertionSamples
{
    public class BooleanSampleTests
    {
        // Arrange
        BooleanSample booleanSample = new BooleanSample();

        [Test]
        public void IsWeekDay_ReturnFalse_WhenSaturday()
        {
            // Arrange
            var dayName = "Saturday";

            // Act
            var result = booleanSample.IsWeekDay(dayName);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsWeekDay_ReturnTrue_WhenWeekDay()
        {
            // Arrange
            var dayName = "Monday";

            // Act
            var result = booleanSample.IsWeekDay(dayName);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsWeekDay_ReturnFalse_WhenInCorrectDay()
        {
            // Arrange
            var dayName = "Mon";

            // Act
            var result = booleanSample.IsWeekDay(dayName);

            // Assert
            Assert.IsFalse(result);
        }
    }
}