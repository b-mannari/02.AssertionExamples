using NUnit.Framework;
using CodeSamplesForAssertion;
using System;
using System.Collections.Generic;

namespace NUnitAssertionSamples
{
    class EqualitySampleTests
    {
        EqualitySample equalitySample = new EqualitySample();
        [Test]
        public void GetWelcomeMessage_ReturnEqual_WhenValidName()
        {
            // Arrange
            string expectedResult = "Welcome Badari";

            // Act
            string actulaResult = equalitySample.GetWelcomeMessage("Badari");

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void GetWelcomeMessage_ReturnNotEqual_WhenNullName()
        {
            // Arrange
            string expectedResult = "Test result";

            // Act
            string actulaResult = equalitySample.GetWelcomeMessage(null);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void GetTextAppendWithRandomNumber_ReturnNotEqual_WhenNullName()
        {
            // Arrange
            string Name = "Test 123";

            // Act
            string actulaResult1 = equalitySample.GetTextAppendWithRandomNumber(Name);
            string actulaResult2 = equalitySample.GetTextAppendWithRandomNumber(Name);

            // Assert
            Assert.AreNotEqual(actulaResult1, actulaResult2);
        }


        [Test]
        public void AddNumbers_ReturnEqual_WhenSumOfTwoNumbersEqualToResult()
        {
            // Arrange
            int num1 = 3; int num2 = 2; int expectedResult = 5;

            // Act
            int actulaResult = equalitySample.AddNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void AddNumbers_ReturnNotEqual_WhenSumOfTwoNumbersEqualToResult()
        {
            // Arrange
            int num1 = 13; int num2 = 2; int expectedResult = 25;

            // Act
            int actulaResult = equalitySample.AddNumbers(num1, num2);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void GetMaturityAmout_ReturnEqual_WhenMaturityAmoutEqualToResult()
        {
            // Arrange
            double principal = 1000; double interest = 4;
            double expectedResult = principal + (principal * interest / 100);

            // Act
            double actulaResult = equalitySample.GetMaturityAmout(principal, interest);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void GetMaturityAmout_ReturnEqual_WhenMaturityAmouttoleranceEqualToResult()
        {
            // Arrange
            double principal = 1000; double interest = 5;
            double expectedResult = principal + (principal * interest / 100);

            // Act
            double actulaResult = equalitySample.GetMaturityAmout(principal, interest);

            // Assert
            Assert.That(actulaResult, Is.EqualTo(expectedResult).Within(0.00001).Percent);
        }
        
        [Test]
        public void WeekendDays_ReturnEqual_WhenListHasWeekEnds()
        {
            // Arrange
            var expected = new List<string>
            {
                "Saturday",
                "Sunday"
            };

            // Act
            var actual = equalitySample.WeekendDays();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WeekendDays_ReturnNotEqual_WhenListHasNoWeekEnds()
        {
            // Arrange
            var expected = new List<string>
            {
                "Saturday",
                "Sunday",
                "Monday"
            };

            // Act
            var actual = equalitySample.WeekendDays();

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void WeekendDays_ReturnNotEqual_WhenListIsNull()
        {
            // Arrange
            int expected = 0;

            // Act
            var actual = equalitySample.WeekendDays().Count;

            // Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}
