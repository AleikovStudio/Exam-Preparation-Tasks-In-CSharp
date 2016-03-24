using System;

class Boat20December2014
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//5

        for (int i = 0, count = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}{1}{2}",
                new string('.', n - 1 - 2 * count),
                new string('*', 1 + 2 * count),
                new string('.', n));
                count++;
            }
            else
            {
                Console.WriteLine("{0}{1}{2}",
                new string('.', n - 1 - 2 * count),
                new string('*', 1 + 2 * count),
                new string('.', n));
                count--;
            }
        }
    }
}