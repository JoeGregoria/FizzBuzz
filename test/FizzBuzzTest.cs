using System;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [Fact]
        public void WhenSent1Returns1()
        {
            Assert.Equal("1", fizzBuzz.Fizz(1));
        }

        [Fact]
        public void WhenSent2Returns2()
        {
            Assert.Equal("2", fizzBuzz.Fizz(2));
        }

        [Fact]
        public void WhenSent3ReturnsFizz()
        {
            Assert.Equal("fizz", fizzBuzz.Fizz(3));
        }
    }
}
