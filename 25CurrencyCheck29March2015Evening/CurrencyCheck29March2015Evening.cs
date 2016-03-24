using System;

class CurrencyCheck29March2015Evening
{
    static void Main()
    {
        //prices before converting
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal bg1 = decimal.Parse(Console.ReadLine());
        decimal bg2 = decimal.Parse(Console.ReadLine());

        //prices after converting
        decimal a = rubles * 0.035m;//rublesToLeva
        decimal b = dollars * 1.5m;//dollarsToLeva
        decimal c = euro * 1.95m;//euroToLeva
        decimal d = (bg1 / 2);//bg1ToLeva
        decimal e = bg2;

        //using Math.Min to compare 2 numbers and find out the lowest  

        decimal compareNumbers = Math.Min(a, b);
        decimal compareNumbers1 = Math.Min(c, d);
        decimal compareNumbers2 = Math.Min(compareNumbers1, compareNumbers);
        decimal compareNumbers3 = Math.Min(compareNumbers2,d);
        Console.WriteLine("{0:f2}", compareNumbers3);
    }
}