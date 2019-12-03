using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
     
        [Test]
        public void shouldAddTwoNumber()
        {
            //arrange
            Calculator sum = new Calculator();

            //act
            int result = sum.Add(50, 50);

            //Assert
            Assert.That(result, Is.EqualTo(100), $"The total sum is {result} but was expected 100");
        }
    }
}