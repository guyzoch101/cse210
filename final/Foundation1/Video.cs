public class Video {
    private string _title;
    private string _author;
    private int _lengthSec;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSec) {
        _title = title;
        _author = author;
        _lengthSec = lengthSec;
    }

    public int GetNumberOfComments() {
        int noOfComments = _comments.Count;
        return noOfComments;
    }

    public string LengthMinSec() {
        int min = (int)Math.Floor((double)_lengthSec / 60);
        int sec = _lengthSec % 60;
        string length = $"{min}:{sec}";
        
        return length; // returns the string in the form of mm:ss
    }

    public void AddToCommentList(Comment comment) {
        _comments.Add(comment); // adds a comment into _comments
    }

    public void DisplayVideoDetails() {
        string videoDetails = $"{_title} ~ {_author} ({LengthMinSec()})"; // title, author, video length
        Console.WriteLine(videoDetails);

        Console.WriteLine($"Comments ({GetNumberOfComments()})"); // number of comments
        foreach (Comment comment in _comments) {
            comment.DisplayCommentDetails(); // iterates _comments -> display all comments associated with the video
        }

        Console.WriteLine();
    }
}