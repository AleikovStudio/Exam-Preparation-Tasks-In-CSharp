using System;

class ArrayMatcher29March2015Evening
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string leftArray = input[0];
        string rightdArray = input[1];
        string command = input[2];

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
        }

        //using switch case for the commands
        switch (command)
        {
            case "join": //TODO
                break;
            case "left exclude": //TODO
                break;
            case "right exclude": //TODO
                break;
        }


    }
}