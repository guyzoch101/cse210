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

    public void AddToCommentList(Comment comment) {
        _comments.Add(comment);
    }

    public void DisplayVideoDetails() {
        string videoDetails = $"Title: {_title} ~ Author: {_author} ~ Length: {_lengthSec} seconds";
        Console.WriteLine(videoDetails);
    }

    public void DisplayAllComments() {
        foreach (Comment comment in _comments) {
            comment.DisplayCommentDetails();
        }
    }
}