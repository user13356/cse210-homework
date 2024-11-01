using System;
using System.Collections.Generic;

namespace YouTubeTracker

{
    public class Video

    {

        public string VideoId { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }

}
