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
        
        return length;
    }

    public void AddToCommentList(Comment comment) {
        _comments.Add(comment);
    }

    public void DisplayVideoDetails() {
        string videoDetails = $"{_title} ~ {_author} ({LengthMinSec()})";
        Console.WriteLine(videoDetails);
    }

    public void DisplayAllComments() {
        foreach (Comment comment in _comments) {
            comment.DisplayCommentDetails();
        }
    }
}