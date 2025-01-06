using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private InstallerHelper _installerHelper;
        private Mock<IClient> _client;

        [SetUp]
        public void SetUp()
        {
            _client = new Mock<IClient>();
            _installerHelper = new InstallerHelper(_client.Object);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnsFalse()
        {
            //_client.Setup(c => c.DownloadFile("http://example.com/customer/installer", null)).Throws<WebException>();

            //To make it simpler and shorter we use It.IsAny<string>()
            _client.Setup(c =>
            c.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
            .Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void DownloadInstaller_DownloadComplete_ReturnsTrue()
        {
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.EqualTo(true));
        }

    }
}
