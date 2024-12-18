using System;
public class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public int NumberOfComment()
    {
        return _comments.Count;
    }
    public void ShowAllComment()
    {
        foreach(var comment in _comments)
        {
            Console.WriteLine($"Comment by {comment._name}: {comment._text}");
        }
    }
}