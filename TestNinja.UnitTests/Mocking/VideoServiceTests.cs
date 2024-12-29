using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void SetUp()
        {
            //Refactored code, so that we won't be newing up the fileReader and service objects everytime 
            //we create a new test
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {   
            //The Moq Framework is not yet implemented.
            //var service = new VideoService(new MockFileReader());
            
            //After the Moq Framework is implemented and the MockFileReader Class is deleted,
            //We use Moq Library to create a dynamic mock. We Select the Mock from Moq Name Space.
            //var _fileReader = new Mock<IFileReader>();
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void ReadVideoTitle_NotEmptyFile_ReturnErrorMessage()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("video.txt");

            var result = _videoService.ReadVideoTitle();
            
            Assert.That(result, Is.EqualTo("video.txt").IgnoreCase);
        }
    }
}
