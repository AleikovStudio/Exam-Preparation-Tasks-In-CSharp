using System;

class BabaTincheAirlines8November2014
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        int firstClassAll = int.Parse(firstClass[0]);
        int firstClassFrFl = int.Parse(firstClass[1]);
        int firstClassMeal = int.Parse(firstClass[2]);

        string[] secondClass = Console.ReadLine().Split();
        int secondClassAll = int.Parse(secondClass[0]);
        int secondClassFrFl = int.Parse(secondClass[1]);
        int secondClassMeal = int.Parse(secondClass[2]);

        string[] thirdClass = Console.ReadLine().Split();
        int thirdClassAll = int.Parse(thirdClass[0]);
        int thirdClassFrFl = int.Parse(thirdClass[1]);
        int thirdClassMeal = int.Parse(thirdClass[2]);

        decimal firstClassIncome = (int)(((firstClassAll - firstClassFrFl) * 7000)) + (firstClassFrFl * 2100) + (firstClassMeal * 35);
        decimal secondClassIncome = (int)(((secondClassAll-secondClassFrFl) * 3500)) + (secondClassFrFl * 1050) + (secondClassMeal * 17.5m);
        decimal thirdClassIncome = (int)(((thirdClassAll-thirdClassFrFl) * 1000)) + (thirdClassFrFl * 300) + (thirdClassMeal * 5);

        decimal babaTincheIncome = (int)firstClassIncome + secondClassIncome + thirdClassIncome;
        decimal maxIncome = (int)((12 * 7000) + (12 * 35)) + (28 * 3500 + (28 * 17.5m)) + (50 * 1000 + (50 * 5));

        Console.WriteLine((int)babaTincheIncome);
        Console.WriteLine((int)maxIncome - (int)babaTincheIncome);
    }
}