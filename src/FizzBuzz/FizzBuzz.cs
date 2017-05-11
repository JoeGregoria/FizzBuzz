using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Fizz(int value)
        {
            if (value == 3) return "fizz";
            if (value == 5) return "buzz";
            return (value.ToString());
        }
    }
}
