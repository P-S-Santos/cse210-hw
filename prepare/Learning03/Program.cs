using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3,4);
        Fraction fourth = new Fraction(1,3);
        Console.WriteLine(first.GetFractionString()+"\n"+first.GetDecimalValue());
        Console.WriteLine(second.GetFractionString()+"\n"+second.GetDecimalValue());
        Console.WriteLine(third.GetFractionString()+"\n"+third.GetDecimalValue());
        Console.WriteLine(fourth.GetFractionString()+"\n"+fourth.GetDecimalValue());
    }
}