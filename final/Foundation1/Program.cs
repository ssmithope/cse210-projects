using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title = "Video 1",
                Author = "Author 1",
                Length = 120,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "User 1", Text = "Great video!" },
                    new Comment { CommenterName = "User 2", Text = "Very informative." }
                }
            },
            new Video
            {
                Title = "Video 2",
                Author = "Author 2",
                Length = 150,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "User 3", Text = "Awesome content!" },
                    new Comment { CommenterName = "User 4", Text = "Thanks for sharing." }
                }
            }
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}s, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation1 World!");
//     }
// }