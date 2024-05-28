public class Comment {
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText) {
        _name = name;
        _commentText = commentText;
    }

    public void DisplayCommentDetails() {
        string commentDetails = $"{_commentText} ~ by {_name}";
        Console.WriteLine(commentDetails);
    }
}