using System;
class Dumbbell29March2015
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}",
                new string(('.'), n / 2),
                new string(('&'), n / 2 + 1),
                new string(('.'), n));

        for (int i = 0; i < n / 2 - 1; i++)//0;1;2
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                    new string(('.'), n / 2 - 1 - i),//2//1
                    new string(('*'), n / 2 + i),//3//4
                    new string(('.'), n));//7
        }
        Console.WriteLine("&{0}&{1}&{0}&",
                    new string(('*'), n - 2),
                    new string(('='), n));

        for (int i = 0; i < n / 2 - 1; i++)//0;1;2
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                    new string(('.'), i+1),    
                    new string(('*'), n-3-i),//5=2//7=4,3//9=6,5//11=8,7
                    new string(('.'), n));//7
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string (('.'),n/2),
            new string (('&'),n/2+1),
            new string (('.'),n));
    }
}
