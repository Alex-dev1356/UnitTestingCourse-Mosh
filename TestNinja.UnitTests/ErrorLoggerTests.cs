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
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        //To make sure that our test is a trustworthy test, we go back on the ErroLogger Class and we know that the 
        //LastError = error is the line that is responsible for making our test pass, so if we comment that one our
        //our test should fail but if it still passes that means our test is wrong and needs to be modified. It is 
        //testing the wrong thing.
    }
}
