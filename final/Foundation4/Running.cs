using System;

class Running : Activity
{
    public double _distance { get; set; }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Running ({_length} min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}