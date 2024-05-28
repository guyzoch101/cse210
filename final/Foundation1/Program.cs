using System;

class Program
{
    static void Main(string[] args)
    {
        // list of videos to store Video objects created
        List<Video> _videos = new List<Video>();

        // video1
        Video video1 = new Video("C# Tips", "Coding Tips", 1000);

        // comments associated with video1
        Comment comment1a = new Comment("CodingBeginner", "Very helpful video for my assignment!");
        video1.AddToCommentList(comment1a); // adding comment to list
        Comment comment1b = new Comment("CodingGeek", "I would suggest adding a part to explain the differences betweem C# and Python.");
        video1.AddToCommentList(comment1b); // adding comment to list
        Comment comment1c = new Comment("Tristan", "Explained difficult concepts with simple terms and ideas.");
        video1.AddToCommentList(comment1c); // adding comment to list

        _videos.Add(video1); // adding video to list

        // video2
        Video video2 = new Video("How to Eat Healthier?", "Healthy Life", 500);

        // comments associated with video2
        Comment comment2a = new Comment("Mom at Rexburg", "Looks like it's gonna be a healthy dinner for my kids tonight.");
        video2.AddToCommentList(comment2a); // adding comment to list
        Comment comment2b = new Comment("Gym Rat", "New diet for me!");
        video2.AddToCommentList(comment2b); // adding comment to list
        Comment comment2c = new Comment("Tristan", "Good for keeping fit.");
        video2.AddToCommentList(comment2c); // adding comment to list

        _videos.Add(video2);

        foreach(Video video in _videos) {
            video.DisplayVideoDetails(); // title, author, video length
            Console.WriteLine($"Comments ({video.GetNumberOfComments()})"); // number of comments
            video.DisplayAllComments(); // all comments

            Console.WriteLine();
        }
    }
}