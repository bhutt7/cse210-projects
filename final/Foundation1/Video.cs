public class Video
{
    private string _title;
    private string _author;
    private double _seconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int NumComments()
    {
        return _comments.Count;
    }

    public void ListComments()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.Display());
        }
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in seconds): {_seconds}");
        Console.WriteLine("Comments:");
        ListComments();
    }
}