using System;

class Numerology8November2014
{
    static void Main()
    {
        string[] userData = Console.ReadLine().Split('.', ' ');
        int day = int.Parse(userData[0]);
        int month = int.Parse(userData[1]);
        int year = int.Parse(userData[2]);
        string userName = userData[3];

        long result = day * month * year;

        if (month % 2 != 0)
        {
            result *= result;
        }

        foreach (var symbol in userName)
        {
            if (symbol >= '0' && symbol <= '9')// 0 v ASCII tablicata e 48; 9 e 57
            {
                int digit = symbol - '0';
                result += digit;
            }
            else if (symbol >= 'a' && symbol <= 'z')// a v ASCII tablicata e 97; z e 122
            {
                int digit2 = symbol - ('a' + 1);
                result += digit2;
            }
            else if (symbol >= 'A' && symbol <= 'Z')// A v ASCII tablicata e 65; Z e 90
            {
                int digit3 = 2 * (symbol - ('A' + 1));
                result += digit3;
            }
        }
        while (result > 13)
        {
            int digitSum = 0;

            while (result > 0)
            {
                digitSum += (int)(result % 10);
                result /= 10;
            }
            result = digitSum;
        }
        Console.WriteLine(result);
    }
}