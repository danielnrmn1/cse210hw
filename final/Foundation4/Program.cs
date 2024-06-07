using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running()
        {
            _date = new DateTime(2022, 11, 3),
            _length = 30,
            _distance = 3.0
        };
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling()
        {
            _date = new DateTime(2022, 11, 3),
            _length = 30,
            _speed = 9.7
        };
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming()
        {
            _date = new DateTime(2022, 11, 3),
            _length = 30,
            _laps = 60
        };
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }    
}