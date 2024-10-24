using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace YouTubeTracker

{
    class Program

    {

        private static readonly HttpClient client = new HttpClient();

        // Google API key for Youtube 
        private const string ApiKey = "AIzaSyB6Xqvs30GoiabfWkaJo0JobqVVaGPsuww"; 

        // Channel ID
        private const string ChannelId = "UCS1uNW3nmPdTSzJ5ZeSL2KA"; 

        static async Task Main(string[] args)

        {

            try

            {

                Console.WriteLine("Fetching videos...");
                var videos = await FetchVideos();

                // Display video information
                foreach (var video in videos)

                {

                    Console.WriteLine($"Title: {video.Title}\nPublished At: {video.PublishedAt}\nVideo ID: {video.VideoId}");
                    foreach (var comment in video.Comments)

                    {
                        Console.WriteLine($"\tComment by {comment.Author}: {comment.Text}");

                    }

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Error: {ex.Message}");

            }

        }

        private static async Task<List<Video>> FetchVideos()

        {

            var videoRequestUrl = $"https://www.googleapis.com/youtube/v3/search?key={ApiKey}&channelId={ChannelId}&part=snippet,id&order=date&maxResults=5";

            var response = await client.GetStringAsync(videoRequestUrl);
            var json = JObject.Parse(response);

            var videos = new List<Video>();

            foreach (var item in json["items"])

            {

                var videoId = item["id"]["videoId"]?.ToString();
                var title = item["snippet"]["title"]?.ToString();
                var publishedAt = DateTime.Parse(item["snippet"]["publishedAt"]?.ToString());

                var video = new Video

                {

                    VideoId = videoId,
                    Title = title,
                    PublishedAt = publishedAt,

                    // Initialize Comments list
                    Comments = new List<Comment>() 
                };

                    // Fetch comments for each video
                if (!string.IsNullOrEmpty(videoId))

                {

                    video.Comments = await FetchComments(videoId);

                }


                videos.Add(video);
            }

            return videos;
        }

        private static async Task<List<Comment>> FetchComments(string videoId)

        {

            var commentRequestUrl = $"https://www.googleapis.com/youtube/v3/commentThreads?key={ApiKey}&textFormat=plainText&part=snippet&videoId={videoId}&maxResults=5";

            var response = await client.GetStringAsync(commentRequestUrl);
            var json = JObject.Parse(response);

            var comments = new List<Comment>();

            foreach (var commentItem in json["items"])

            {
                var comment = new Comment

                {

                    Author = commentItem["snippet"]["topLevelComment"]["snippet"]["authorDisplayName"]?.ToString(),
                    Text = commentItem["snippet"]["topLevelComment"]["snippet"]["textDisplay"]?.ToString()

                };

                comments.Add(comment);

            }

            return comments;
        }

    }

    // Define the Video class
    public class videos

    {

        public string VideoId { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public List<Comment> Comments { get; set; }

    }

    // Define the Comment class
    public class comments

    {

        public string Author { get; set; }
        public string Text { get; set; }

    }

}
