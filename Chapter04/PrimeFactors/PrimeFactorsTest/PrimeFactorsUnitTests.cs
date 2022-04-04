using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsTest
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test2()
        {
            // arrange
            int a = 2;
            string expected = "2";
            PrimeFactorsClass primer = new();
            // act
            string actual = primer.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            // arrange
            int a = 3;
            string expected = "3";
            PrimeFactorsClass primer = new();
            // act
            string actual = primer.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test7()
        {
            // arrange
            int a = 7;
            string expected = "7";
            PrimeFactorsClass primer = new();
            // act
            string actual = primer.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }

        public void Test14()
        {
            // arrange
            int a = 14;
            string expected = "2x7";
            PrimeFactorsClass primer = new();
            // act
            string actual = primer.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}