using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //Demerit Points Exercise
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPoints;

        [SetUp]
        public void SetUp()
        {
            _demeritPoints = new DemeritPointsCalculator();
        }

        //When the speed is Negative and the other test case is when the speed is 300 since cars won't run faster than that in real life
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsLessThanZeroOrGreaterThanMaxSpeed_ThrowsArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _demeritPoints.CalculateDemeritPoints(speed), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var points = _demeritPoints.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(expectedResult));
        }
    }
}
