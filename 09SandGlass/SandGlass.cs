using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}",
            new string(('*'), n));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",//0,1,2
                new string(('.'), i + 1),
                new string(('*'), n - 2 - 2 * i));//7=5,3; 9=7,5,3; 11=9,7,5,3
        }
        Console.WriteLine("{0}*{0}",
            new string(('.'), n / 2));

        for (int i = 0; i < n / 2 - 1; i++)//0,1,2
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('.'), n / 2 - 1 - i),
                new string(('*'), 3 + i * 2));//5 =3; 7 = 3,5; 9 = 3,5,7
        }

        Console.WriteLine("{0}",
            new string(('*'), n));
    }
}