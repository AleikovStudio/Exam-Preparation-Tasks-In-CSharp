using System;

class WorkHoursLelyaVanche11April2014M
{
    static void Main()
    {
        decimal h = decimal.Parse(Console.ReadLine());//h - the required work hours to finish the project
        decimal d = decimal.Parse(Console.ReadLine());//d - the days available to finish the project
        decimal p = decimal.Parse(Console.ReadLine());//p - the productivity in percent

        decimal hours = (d * 0.9m) * 12;
        decimal effHours = (int)(hours * (p / 100));

        if (h > effHours)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", effHours - h);
        }
        else if (effHours >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", effHours - h);
        }
    }
}