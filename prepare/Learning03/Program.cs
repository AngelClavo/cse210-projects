using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.WrittenFraction());
        Console.WriteLine(f1.Decimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.WrittenFraction());
        Console.WriteLine(f2.Decimal());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.WrittenFraction());
        Console.WriteLine(f3.Decimal());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.WrittenFraction());
        Console.WriteLine(f4.Decimal());
    }
}