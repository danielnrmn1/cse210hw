using System;

class Cycling : Activity
{
    public double _speed { get; set; }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Cycling ({_length} min) - Speed: {_speed} kph, Pace: {GetPace()} min per km";
    }
}