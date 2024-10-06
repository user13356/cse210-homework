using System;

public class Fraction

{
    private int _top;
    private int _bottom;

    public Fraction()

    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)

    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)

    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    
    {
        // Variable not stored
        // Recalling and calculating 

        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()

    {
        // Variable not stored.
        // Recalculated on each run.

        return (double)_top / (double)_bottom;
    }
}