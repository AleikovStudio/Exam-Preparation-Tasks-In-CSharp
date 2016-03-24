using System;

class DreamItem29March2015Evening
{
    static void Main()
    {
        string[] arrayData = Console.ReadLine().Split('\\');
        string month = arrayData[0];
        decimal moneyPerHour = decimal.Parse(arrayData[1]);
        decimal hoursPerDay = decimal.Parse(arrayData[2]);
        decimal priceOfTheItem = decimal.Parse(arrayData[3]);

        decimal workingDays = 0;

        switch (month)
        {
            case "Feb":
                workingDays += 28; break;

            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                workingDays += 30; break;

            case "Jan":
            case "March":
            case "May":
            case "July":
            case "Aug":
            case "Oct":
            case "Dec":
                workingDays += 31; break;
        }
        decimal workingDaysWihtoutHolidays = workingDays - 10;

        decimal moneyPerDay = moneyPerHour * hoursPerDay;
        decimal earningsPerMonthNoBonus = workingDaysWihtoutHolidays * moneyPerDay;

        decimal earningsPerMonth = 0;
        if (earningsPerMonthNoBonus > 700)
        {
            earningsPerMonth = earningsPerMonthNoBonus + (earningsPerMonthNoBonus * 0.1m);
        }
        else if (earningsPerMonthNoBonus < 700)
        {
            earningsPerMonth = earningsPerMonthNoBonus;
        }

        if (priceOfTheItem > earningsPerMonth)
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfTheItem - earningsPerMonth);
        }
        else if (earningsPerMonth > priceOfTheItem)
        {
            Console.WriteLine("Money left = {0:f2} leva.", earningsPerMonth - priceOfTheItem);
        }
        else if (earningsPerMonth == priceOfTheItem)
        {
            Console.WriteLine("Money left = {0:f2} leva.", earningsPerMonth - priceOfTheItem);
        }
    }
}