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
    public class CustomerControllerTests
    {
        //Returns a Not Found Object since User Id is Zero
        [Test]
        public void GetCustomer_UserIdIsZero_ReturnsNotFound()
        {
            var customerController = new CustomerController();

            var result = customerController.GetCustomer(0);

            //With TypeOf it is specific that it is of type Not Found Object (Prefered way of writing this test)
            Assert.That(result, Is.TypeOf<NotFound>());
            //With InstanceOf it is less specific meaning the result CAN BE a Not Found Object or One of it's derivatives.
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        //Returns a Ok Object since User Id is not zero
        [Test]
        public void GetCustomer_UserIdIsNotZero_ReturnsOk()
        {
            var customerController = new CustomerController();

            var result = customerController.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
