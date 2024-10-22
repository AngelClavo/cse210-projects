using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int realNbr)
    {
        _top = realNbr;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string WrittenFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double Decimal()
    {
        return (double)_top / (double)_bottom;
    }
}