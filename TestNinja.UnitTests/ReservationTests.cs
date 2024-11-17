//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using System;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    //<---- Using MS Test ----->
    #region
    //[TestClass]
    //public class ReservationTests
    //{
    //    [TestMethod]
    //    //Good Naming Convention in naming the method you have to test: NameOfTheMethod_Scenario_ExpectedBehaviour()
    //    public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
    //    {
    //        //3 parts of every test method: Arrange, Act and Assert

    //        //Arrange - Where we initialized our objects
    //        var reservation = new Reservation();

    //        //Act - Here we specify the method or function that we want to test and supply the parameters/arguments needed
    //        var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

    //        //Assert - Here we verify that result if correct.
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_SameUsercCanceling_ReturnsTrue()
    //    {
    //        var user = new User();
    //        var reservation = new Reservation();

    //        var result = reservation.CanBeCancelledBy(reservation.MadeBy = user);

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanbeCancelledBy_AnotherUserCancelling_ReturnsFalse()
    //    {
    //        var reservation = new Reservation { MadeBy = new User() };

    //        var result = reservation.CanBeCancelledBy(new User());

    //        Assert.IsFalse(result);
    //    }
    //}
    #endregion

    //<---- Using NUnit Test ----->
    #region
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        //Good Naming Convention in naming the method you have to test: NameOfTheMethod_Scenario_ExpectedBehaviour()
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //3 parts of every test method: Arrange, Act and Assert

            //Arrange - Where we initialized our objects
            var reservation = new Reservation();

            //Act - Here we specify the method or function that we want to test and supply the parameters/arguments needed
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert - Here we verify that result if correct.
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUsercCanceling_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(reservation.MadeBy = user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanbeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.That(result, Is.False);
        }
    }
    #endregion
}