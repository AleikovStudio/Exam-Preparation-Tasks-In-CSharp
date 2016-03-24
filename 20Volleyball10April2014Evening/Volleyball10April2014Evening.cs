using System;

class Volleyball10April2014Evening
{
    static void Main()
    {
        string yearType = Console.ReadLine();//The string “leap” for leap year or “normal” for year that is not leap.
        int pHolidays = int.Parse(Console.ReadLine());//The number p – number of holidays in the year (which are not Saturday or Sunday).
        int hWeekendsInHome = int.Parse(Console.ReadLine());//The number h – number of weekends that Vladi spends in his hometown.

        int allWeekendsYear = 48;
        int normalWeekends = allWeekendsYear - hWeekendsInHome;
        double totalPlays = normalWeekends * 3.0/4;
        totalPlays += hWeekendsInHome;
        totalPlays += pHolidays*2.0/3;

        switch (yearType)
        {
            case "leap": totalPlays += totalPlays * 0.15;
                break;
            case "normal": totalPlays = totalPlays;
                break; 
        }
        Console.WriteLine(Math.Floor(totalPlays));
    }
}