using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private readonly IFileReader _fileReader;
        private readonly IVideo _video;
        private readonly IVideoRepository _videoRepository;

        //public VideoService()
        //{
        //    _fileReader = new FileReader();
        //}

        public VideoService(IFileReader fileReader, IVideo video, IVideoRepository videoRepository)
        {
            _fileReader = fileReader;
            _video = video;
            _videoRepository = videoRepository;
        }

        //We can refactor our Constructor to combine the two constructors with this technique
        //public VideoService(IFileReader fileReader = null)
        //{
        //    //This code means that IF the fileReader IS NOT NULL, we're going to use that to
        //    //set this private field, otherwise we're gonna new up this FileReader Object. 
        //    _fileReader = fileReader ?? new FileReader();
        //}
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            //var video = new Video() {Title = str};
            //var video = JsonConvert.DeserializeObject<Video>(str);
            var video = _video;
            if (String.IsNullOrEmpty(video.Title))
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            var videos = _videoRepository.GetUnprocessedVideos();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }
    }

    public interface IVideo
    {
        int Id { get; set; }
        bool IsProcessed { get; set; }
        string Title { get; set; }
    }

    public class Video : IVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}