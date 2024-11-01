using System;

public class Swimming : Exercise
{
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }
    // Calculations for speed, distance and pace
    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double CalculateSpeed()
    {
        double speed = CalculateDistance() / _minutes * 60;
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = _minutes / CalculateDistance();
        return pace;
    }
}