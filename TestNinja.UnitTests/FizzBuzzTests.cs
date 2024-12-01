using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //FizzBuzz Exercise
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public static void GetOutput_DivisibleBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_DivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisibleBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(7)]
        [TestCase(-1)]
        public void GetOutput_NotDivisibleBy3or5AndNegativeNumber_ReturnsSameNumber(int inputNumber)
        {
            var result = FizzBuzz.GetOutput(inputNumber);

            Assert.That(result, Is.EqualTo(inputNumber.ToString()));
        }
    }
}
