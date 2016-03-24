using System;

class PlaidTowel18October2015
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}#{1}#{0}",//3=5; 4=7; 5=9
            new string(('.'), n),
            new string(('.'), n * 2 - 1));

        for (int i = 0; i < n - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string(('.'), n - 1 - i),
                new string(('.'), 1 + i * 2),//3=1,3; 4 = 1,3,5
                new string(('.'), n * 2 - 3 - 2 * i));//3 = 3,1; 4 = 5,3,1
        }
        Console.WriteLine("#{0}#{0}#",
            new string(('.'), n * 2 - 1));

        for (int i = 0; i < n - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string(('.'), i + 1),
                new string(('.'), n * 2 - 3 - 2 * i),//3=3,1; 4 = 5,3,1
                new string(('.'), 1 + i * 2));//3=1,3; 4 = 1,3,5
        }
        
        Console.WriteLine("{0}#{1}#{0}",//3=5; 4=7; 5=9
            new string(('.'), n),
            new string(('.'), n * 2 - 1));

        for (int i = 0; i < n - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string(('.'), n - 1 - i),
                new string(('.'), 1 + i * 2),//3=1,3; 4 = 1,3,5
                new string(('.'), n * 2 - 3 - 2 * i));//3 = 3,1; 4 = 5,3,1
        }
        Console.WriteLine("#{0}#{0}#",
            new string(('.'), n * 2 - 1));

        for (int i = 0; i < n - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string(('.'), i + 1),
                new string(('.'), n * 2 - 3 - 2 * i),//3=3,1; 4 = 5,3,1
                new string(('.'), 1 + i * 2));//3=1,3; 4 = 1,3,5
        }
        Console.WriteLine("{0}#{1}#{0}",//3=5; 4=7; 5=9
            new string(('.'), n),
            new string(('.'), n * 2 - 1));
    }
}