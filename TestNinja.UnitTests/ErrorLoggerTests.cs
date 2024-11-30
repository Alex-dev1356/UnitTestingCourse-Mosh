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
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        //Using Set-up Method
        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //If we call Log method then it will throw an error and our test is gonna fail. So the way to write assertions for methods that throw exceptions
            //is by using a DELEGATE. We need to wrap this method inside a delegate when writing the Assertion.
            //_logger.Log(error);

            //Using a Delegate
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
            ////Another way of writing Assertion for methods that throw exceptions is by using this one. Where you can specify the type of error its gonna throw.
            //Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }
    }
    #endregion
}
