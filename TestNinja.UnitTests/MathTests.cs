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
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var math = new Fundamentals.Math();

            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        //Black-box Testing
        //On testing the Max Method we have morethan one execution path, the first one is when the first argument is greater, second is 
        //when the second argument is greater and lastly if BOTH the Arguments are equal.

        //When First Argument is greater
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(2,1);

            Assert.That(result, Is.EqualTo(2));
        }


        //When Second Argument is greater
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsTheSecondArgument()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        //When Both Arguments are equal
        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheArgument()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        //Key Takeaway: When Testing a Method you have to think about all the possible Execution Paths.The best way to write test for a method is to
        //THINK OF IT AS A BLACK BOX. This means you have to think about all the possible Execution Paths.
    }
}
