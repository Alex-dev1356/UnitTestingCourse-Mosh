using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        private EmployeeController _employeeController;
        private Mock<IEmployeeStorage> _storage;

        [SetUp]
        public void SetUp()
        {
            _storage = new Mock<IEmployeeStorage>();
            _employeeController = new EmployeeController(_storage.Object);
        }

        [Test]
        public void DeleteEmployee_WhenCalled_DeleteEmployeeFromDb()
        {
            _employeeController.DeleteEmployee(1);
            
            _storage.Verify(s => s.DeleteEmployee(1));

            //var result = _employeeController.DeleteEmployee(1);

            //Assert.That(result, Is.InstanceOf<RedirectResult>());
        }

        [Test]
        public void DeleteEmployee_VerifyRedirectToAction_Exists()
        {
            var result =_employeeController.DeleteEmployee(1);

            Assert.That(result, Is.InstanceOf<RedirectResult>());
        }
    }
}
