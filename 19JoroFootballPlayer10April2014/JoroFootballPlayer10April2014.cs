using System;

class JoroFootballPlayer10April2014
{
    static void Main()
    {
        string yearType = Console.ReadLine();//“t” for leap year – 366 or “f” for year that is not leap - 365
        decimal pHolidays = decimal.Parse(Console.ReadLine());//number of holidays in the year (which are not Saturday or Sunday).
        decimal hInHome = decimal.Parse(Console.ReadLine());//number of weekends that Joro spends in his hometown.

        decimal weekendsInYear = 52;

        decimal weekendPlaysWihtoutHoliday = (weekendsInYear - hInHome);
        decimal weekendPlays = (weekendPlaysWihtoutHoliday * 0.6666666666666667m);//When he is not tired  - meaning 2/3 of the weekends (1-1/3(tired))
        decimal holidayPlays = (pHolidays * 0.5m);
        decimal allPlays = Math.Floor(weekendPlays + holidayPlays) + hInHome;

        switch (yearType)
        {
            case "t": Console.WriteLine(allPlays + 3); break;
            case "f": Console.WriteLine(allPlays); break;
        }
    }
}