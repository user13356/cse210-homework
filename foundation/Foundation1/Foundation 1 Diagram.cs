                      +---------------------+
                      |       Program       |
                      +---------------------+
                               |
                               | calls
                               v
                      +---------------------+
                      |    FetchVideos      |
                      +---------------------+
                               |
                               | returns List<Video>
                               v
                      +---------------------+
                      |        Video        |
                      +---------------------+
                     /|\                    |
                      |                     | contains
                      |                     |
          +---------------------+           |
          |  VideoId           |            |
          |  Title             |            |
          |  PublishedAt       |            |
          |  Comments          |            |
          +---------------------+           |
                     |                      |
                     |                      | calls
                     |                      |
                     v                      v
              +---------------------+  +---------------------+
              |    FetchComments    |  |      Comment        |
              +---------------------+  +---------------------+
                                        /|\
                                         |
                                         |
                                 +---------------------+
                                 |  Author             |
                                 |  Text               |
                                 +---------------------+
