using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}",//THE 1ST PART - STATIC - ONE ROW
            new string('.', (n * 3 + 1) / 2));

        for (int i = 0; i < (n / 2 + 1); i++)//THE 2ND PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', ((n * 3 + 1) / 2) - 1 - i),
                new string('.', 1 + 2 * i));
        }

        Console.WriteLine("{0}{1}{0}",//THE 3RD PART - STATIC - ONE ROW
            new string('*', (n)),
            new string('.', (n + 2)));

        for (int i = 0; i < n / 2; i++)//THE 4TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', 1 + i),
                new string('.', 3 * n - 2 - 2 * i));
        }

        for (int i = 0; i < n / 2; i++)//THE 5TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                new string('.', n / 2 - 1 - i),
                new string('.', n / 2),
                new string('.', 0 + i),
                new string('.', n));
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}",//THE 6TH PART - STATIC - ONE ROW
                new string('*', n / 2 + 1),
                new string('.', n / 2),
                new string('.', n));

        for (int i = 0; i < n; i++)//THE 7TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{0}*{0}",
                new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}",//THE 8TH PART - STATIC - ONE ROW
            new string('.', n),
            new string('*', n + 2));
    }
}