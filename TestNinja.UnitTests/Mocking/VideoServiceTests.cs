using System;
using System.Collections.Generic;

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
        private Mock<IVideo> _video;
        private Mock<IVideoRepository> _videoRepository;

        [SetUp]
        public void SetUp()
        {
            //Refactored code, so that we won't be newing up the fileReader and service objects everytime 
            //we create a new test
            _fileReader = new Mock<IFileReader>();
            _video = new Mock<IVideo>();
            _videoRepository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_fileReader.Object, _video.Object, _videoRepository.Object);
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
            _video.Setup(v => v.Title).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void ReadVideoTitle_NotEmptyFile_ReturnErrorMessage()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("video.txt");
            _video.Setup(v => v.Title).Returns("video.txt");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Is.EqualTo("video.txt").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosProcessed_ReturnAnEmptyString()
        {
            _videoRepository.Setup(vr => vr.GetUnprocessedVideos()).Returns(new List<Video>());

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AFewUnprocessedVideos_ReturnAStringWithIdsOfUnprocessedVideos()
        {
            _videoRepository.Setup(vr => vr.GetUnprocessedVideos()).Returns(new List<Video> 
            { 
                new Video() {Title = "video1", Id = 1, IsProcessed = false},
                new Video() {Title = "video2", Id = 2, IsProcessed = false },
                new Video() {Title = "video3", Id = 3, IsProcessed = false }
            });

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }
}
