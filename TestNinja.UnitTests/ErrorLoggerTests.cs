using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //Testing Void Methods
    #region
    //[TestFixture]
    //public class ErrorLoggerTests
    //{
    //    [Test]
    //    public void Log_WhenCalled_SetTheLastErrorProperty()
    //    {
    //        var logger = new ErrorLogger();

    //        logger.Log("a");

    //        Assert.That(logger.LastError, Is.EqualTo("a"));
    //    }

    //    //To make sure that our test is a trustworthy test, we go back on the ErroLogger Class and we know that the 
    //    //LastError = error is the line that is responsible for making our test pass, so if we comment that one our
    //    //our test should fail but if it still passes that means our test is wrong and needs to be modified. It is 
    //    //testing the wrong thing.
    //}
    #endregion

    //Testing Methods that Throws Exceptions Error
    #region
    //[TestFixture]
    //public class ErrorLoggerTests
    //{
    //    private ErrorLogger _logger;

    //    //Using Set-up Method
    //    [SetUp]
    //    public void SetUp()
    //    {
    //        _logger = new ErrorLogger();
    //    }

    //    [Test]
    //    [TestCase(null)]
    //    [TestCase("")]
    //    [TestCase(" ")]
    //    public void Log_InvalidError_ThrowArgumentNullException(string error)
    //    {
    //        //If we call Log method then it will throw an error and our test is gonna fail. So the way to write assertions for methods that throw exceptions
    //        //is by using a DELEGATE. We need to wrap this method inside a delegate when writing the Assertion.
    //        //_logger.Log(error);

    //        //Using a Delegate
    //        Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
    //        ////Another way of writing Assertion for methods that throw exceptions is by using this one. Where you can specify the type of error its gonna throw.
    //        //Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
    //    }
    //}
    #endregion

    //Testing Methods that raise an Event
    #region
    [TestFixture]
    public class ErrorLogger
    {
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new Fundamentals.ErrorLogger();

            var id = Guid.Empty;

            //To Verify that this object raises an event, before acting we need to subscribe to that event. So if the Log method raises the event, we'll be notified.
            //To subscribe to the event by adding a new handler (+=) and we use Lambda Expression (sendre, args) so these are parameters, SENDER is the SOURCE OF
            //THE EVENT and ARGS is the ARGUMENTS OF THE EVEN. These parameters go to (=>) the body of our method and this Lambda expression represents our event handler.
            //When the ErrorLogged event is raised, this function will be executed. So in the body of this function, I can get the event argument in this case Event id.
            //So we're gonna define a variable called id and initially set it to an empty Guid. Now when the ErrorLogged event is raise, we're going to set id=args which is
            //the id of this error.
            logger.ErrorLogged += (sender, args) => { id = args; };

            //Now we can ACT.
            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

    }
    #endregion
}