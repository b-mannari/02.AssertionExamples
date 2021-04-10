using NUnit.Framework;
using CodeSamplesForAssertion;
using System;

namespace NUnitAssertionSamples
{
    public class DerivedClassTests
    {
        [Test]
        public void ShoulBeAnInstanceOfAnimal()
        {
            // Arrange
            DerivedClass derivedClass = DerivedClass.GetInstance();

            // Act
            // Assert
            Assert.IsInstanceOf(derivedClass.GetType(), DerivedClass.GetInstance());
        }

        //singleton
        [Test]
        public void ShoulHaveSameInstanceEveryTime()
        {
            // Arrange
            DerivedClass derivedClass1 = DerivedClass.GetInstance();
            DerivedClass derivedClass2 = DerivedClass.GetInstance();

            // Act
            // Assert
            Assert.AreEqual(derivedClass1, derivedClass2);
        }

        [Test]
        public void DerivedClass_ReturnTrue_WhenMoveMethodIsCalled()
        {
            // Arrange
            string Message = "The method or operation is not implemented.";
            var myObject = new DerivedClass();
            bool exceptionThrown = false;

            // Act
            try
            {
                myObject.Move();
            }

            // Assert
            catch (NotImplementedException ex)
            {
                exceptionThrown = true;
                Assert.AreEqual(Message, ex.Message);
            }
            Assert.That(exceptionThrown);
        }
    }
}