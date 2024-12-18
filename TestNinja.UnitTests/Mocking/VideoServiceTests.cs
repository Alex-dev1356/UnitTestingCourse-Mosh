﻿using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {   
            var service = new VideoService();

            var result = service.ReadVideoTitle(new MockFileReader());

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
