using System;
using System.Collections.Generic;

class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comment> _comments { get; set; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment { _name = name, _text = text };
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }
}