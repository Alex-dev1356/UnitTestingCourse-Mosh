using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class RedoingFizzBuzzTests
    {
        [Test]
        [TestCase(15)]
        public void GetOutput_DivisibleBy3And5_ReturnsFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(3)]
        public void GetOutput_DivisibleBy3_ReturnsFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }


        [Test]
        [TestCase(5)]
        public void GetOutput_DivisibleBy5_ReturnsFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(7)]
        public void GetOutput_NotDivisibleBy5or3_ReturnsTheInputNumber(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(number.ToString()));
        }
    }
}   
