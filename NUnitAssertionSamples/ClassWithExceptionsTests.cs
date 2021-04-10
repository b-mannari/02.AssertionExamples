using NUnit.Framework;
using CodeSamplesForAssertion;
using System;

namespace NUnitAssertionSamples
{
    public class ClassWithExceptionsTests
    {
        ClassWithExceptions withExceptions = new ClassWithExceptions();

        [Test]
        public void SayHello_ReturnSuccess_WhenNameIsPassed()
        {
            // Arrange
            string ExpectedName = "Hello Badari";

            // Act
            string result = withExceptions.SayHello("Badari");

            // Assert
            Assert.AreEqual(ExpectedName, result);
        }

        [Test]
        public void SayHello_ReturnFaliure_WhenNullNameIsPassed()
        {
            // Arrange
            string expected = null;
            bool exceptionThrown = false;
           
            // Act
            try
            {
                var result = withExceptions.SayHello(null);
            }
            
            // Assert
            catch (ArgumentNullException ex)
            {
                exceptionThrown = true;
                Assert.AreEqual(expected, ex.ParamName);
            }
            Assert.That(exceptionThrown);
        }
    }
}