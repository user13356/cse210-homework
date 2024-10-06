using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Learning 03 Prepare Fractions");
        Console.WriteLine("");


                Fraction number1 = new Fraction();
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());
        Console.WriteLine("");

        Fraction number2 = new Fraction(9);

        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());
        Console.WriteLine("");

        Fraction number3 = new Fraction(6, 8);

        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());
        Console.WriteLine("");

        Fraction number4 = new Fraction(2, 6);

        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());
        Console.WriteLine("");

        Fraction number5 = new Fraction(12, 14 );

        Console.WriteLine(number5.GetFractionString());
        Console.WriteLine(number5.GetDecimalValue());
        Console.WriteLine("");
    }
}