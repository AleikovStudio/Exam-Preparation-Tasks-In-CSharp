using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FruitMarket14April2014Morning
{
    static void Main()
    {
        //input - data
        string day = Console.ReadLine();
        decimal qProduct1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        decimal qProduct2 = decimal.Parse(Console.ReadLine());
        string product = Console.ReadLine();
        decimal qProduct3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        //fixirani ceni + ceni na plodove i zelenchuci
        decimal banana = 1.80m;
        decimal cucumber = 2.75m;
        decimal tomato = 3.20m;
        decimal orange = 1.60m;
        decimal apple = 0.86m;
        
        decimal vegatables = cucumber + tomato;
        decimal fruits = banana + orange + apple;

        decimal all = vegatables + fruits;
        //switch case za productite???
        //switch za product1
        decimal priceProductDay1 = 0;
        switch (product1)
        {
            case "banana": priceProductDay1 = banana * qProduct1;
                break;
            default:
                break;
        }
        //switch case - s ceni na procentite - obratnite!
        switch (day)
        {
            case "Monday": 
                break;
            case "Tuesday": fruits *= 0.8m;
                break;
            case "Wednesday": vegatables *= 0.9m;
                break;
            case "Thursday": banana *= 0.7m;
                break;
            case "Friday": all *= 0.9m;
                break;
            case "Saturday":
                break;
            case "Sunday": all *= 0.95m;
                break;
        }


        //print the console

    }
}