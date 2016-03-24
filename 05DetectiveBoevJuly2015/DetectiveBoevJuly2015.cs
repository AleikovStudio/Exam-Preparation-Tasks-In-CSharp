using System;

class DetectiveBoevJuly2015
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string message = Console.ReadLine();

        int asciiSum = 0;
        foreach (char charCode in secretWord)
        {
            asciiSum = asciiSum + charCode;
        }
        Console.WriteLine(asciiSum);

        int mask = 0;
        while (asciiSum > 0)
        {
            mask = mask + asciiSum % 10;
            asciiSum = asciiSum / 10;
        }
        Console.WriteLine(mask);
    }
}
