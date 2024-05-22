using System;
using System.Net;
using System.Reflection;

namespace library_demo
{
    public class WritingAssignment : Assignment
    {
        private string _title = "";

        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        }


        public string GetWritingInformation()
        {
            return $"{_title}";
        }
    }
}