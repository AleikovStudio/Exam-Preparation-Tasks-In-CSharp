﻿using System;

class SummertimeHalfBeer12July2015
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",
            new string((' '), ((2 * n) - (n + 1)) / 2),//3-1;5-2;7-3
            new string(('*'), n + 1));

        for (int i = 0; i < n / 2 + 1; i++)//0,1,2;
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string((' '), ((2 * n) - (n + 1)) / 2),
                new string((' '), (n + 1) - 2));//3-2; 5-4; 7-6
        }
        
        for (int i = 0; i < n / 2 - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string((' '), n / 2 - i - 1),
                new string((' '), n + 1 + 2 * i));//5-6; 7-8,10; 9-10, 12
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*",
                new string(('.'), (2 * n - 2)));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*",
                new string(('@'), (2 * n - 2)));
        }

        Console.WriteLine("{0}",
            new string(('*'), 2 * n));
    }
}