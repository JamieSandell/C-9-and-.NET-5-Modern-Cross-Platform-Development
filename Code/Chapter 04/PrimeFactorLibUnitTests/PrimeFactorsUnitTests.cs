using Packt;
using System;
using Xunit;

namespace PrimeFactorLibUnitTests
{
    public class PrimeFactorUnitTests
    {
        [Fact]
        public void TestPrimeFactor4()
        {
            // Arrange
            int number = 4;
            string expected = "Prime factors of 4 are: 2 x 2";
            var primeFactorsLib = new PrimeFactorsLib();
            // Act
            string actual = primeFactorsLib.PrimeFactors(number);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactor7()
        {
            // Arrange
            int number = 7;
            string expected = "Prime factors of 7 are: 7";
            var primeFactorsLib = new PrimeFactorsLib();
            // Act
            string actual = primeFactorsLib.PrimeFactors(number);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactor30()
        {
            // Arrange
            int number = 30;
            string expected = "Prime factors of 30 are: 2 x 3 x 5";
            var primeFactorsLib = new PrimeFactorsLib();
            // Act
            string actual = primeFactorsLib.PrimeFactors(number);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]        
        public void TestPrimeFactor40()
        {
            // Arrange
            int number = 40;
            string expected = "Prime factors of 40 are: 2 x 2 x 2 x 5";
            var primeFactorsLib = new PrimeFactorsLib();
            // Act
            string actual = primeFactorsLib.PrimeFactors(number);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactor50()
        {
            // Arrange
            int number = 50;
            string expected = "Prime factors of 50 are: 2 x 5 x 5";
            var primeFactorsLib = new PrimeFactorsLib();
            // Act
            string actual = primeFactorsLib.PrimeFactors(number);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
