using System;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void whenSent1Returns1()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("1", fizzBuzz.Fizz(1));
        }
    }
}
