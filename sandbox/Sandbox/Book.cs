using System;
using System.Net;
using System.Reflection;

namespace library_demo
{
    public class Book
    {
        protected string _title = "";
        protected string _author = "";

        public Book()
        {
            _author = "Anonymous";
            _title = "Unknown";
        }

        public Book(string author, string title)
        {
            _author = author;
            _title =  title;
        }
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string SetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetBookInfo()
        {
            return $"{_title} by {_author}";
        }
    }
}