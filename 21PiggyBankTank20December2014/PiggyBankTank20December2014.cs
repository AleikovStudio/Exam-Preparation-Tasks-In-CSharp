using System;

class PiggyBankTank20December2014
{
    static void Main()
    {
        decimal priceOfTank = decimal.Parse(Console.ReadLine());//the price of the tank
        decimal partyDays = decimal.Parse(Console.ReadLine());//party days in a month * 5

        decimal daysInMonth = 30;

        decimal realSavingMoneyDays = daysInMonth - partyDays;
        decimal realSavingMoney = realSavingMoneyDays * 2;

        decimal wasteMoney = partyDays * 5;
        realSavingMoney -= wasteMoney;//real saving money per month

        decimal yearsForTank = (priceOfTank / realSavingMoney) / 12;//years required for buying a tank
        decimal monthsForTank = (priceOfTank / realSavingMoney) % 12;//months required for buying a tank

        if (yearsForTank < 0 || monthsForTank < 0)
        {
            Console.WriteLine("never");
        }

        else
        {
            Console.WriteLine("{0} years, {1} months", (int)(yearsForTank), (int)Math.Ceiling(monthsForTank));
        }
    }
}