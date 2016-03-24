using System;

class DailyCalorieIntake
{
    //RESHENA SAMO NA 50%
    static void Main() //Main method - kato BIOS pri PC
    {
        //Men: BMR = 66.5 + (13.75 x weight in kg) + (5.003 x height in cm) – (6.755 x age in years)
        //Women: BMR = 655 + (9.563 x weight in kg) + (1.850 x height in cm) – (4.676 x age in years)

        //Console.WriteLine("Enter your parameters and hit ENTER:");

        //Weight - CONVERT!
        int weight = int.Parse(Console.ReadLine());

        //Height - CONVERT!
        int height = int.Parse(Console.ReadLine());

        //Age
        int age = int.Parse(Console.ReadLine());

        //Gender
        char gender = char.Parse(Console.ReadLine());

        //Workouts Per Week - IMPORTANT!
        int workouts = int.Parse(Console.ReadLine());

        double weightU = (weight / 2.2);
        double heightU = (height * 2.54);

        if (gender == 'm')
        {
            double bmrM = 66.5 + (13.75 * weightU) + (5.003 * heightU) - (6.755 * age);
            //Console.WriteLine(bmrM);

            switch (workouts)
            {
                case 0: Console.WriteLine("{0:0}", (int)(bmrM * 1.2)); break;
                case 1: Console.WriteLine("{0:0}", (int)(bmrM * 1.375)); break;
                case 2: Console.WriteLine("{0:0}", (int)(bmrM * 1.375)); break;
                case 3: Console.WriteLine("{0:0}", (int)(bmrM * 1.375)); break;
                case 4: Console.WriteLine("{0:0}", (int)(bmrM * 1.55)); break;
                case 5: Console.WriteLine("{0:0}", (int)(bmrM * 1.55)); break;
                case 6: Console.WriteLine("{0:0}", (int)(bmrM * 1.55)); break;
                case 7: Console.WriteLine("{0:0}", (int)(bmrM * 1.725)); break;
                case 8: Console.WriteLine("{0:0}", (int)(bmrM * 1.725)); break;
                case 9: Console.WriteLine("{0:0}", (int)(bmrM * 1.725)); break;

                default: Console.WriteLine("{0:0}", (int)(bmrM * 1.9)); break;
            }
        }
        else if (gender == 'f')
        {
            double bmrF = 655 + (9.563 * weightU) + (1.850 * heightU) - (4.676 * age);
            //Console.WriteLine(bmrF);

            switch (workouts)
            {
                case 0: Console.WriteLine("{0:0}", (int)(bmrF * 1.2)); break;
                case 1: Console.WriteLine("{0:0}", (int)(bmrF * 1.375)); break;
                case 2: Console.WriteLine("{0:0}", (int)(bmrF * 1.375)); break;
                case 3: Console.WriteLine("{0:0}", (int)(bmrF * 1.375)); break;
                case 4: Console.WriteLine("{0:0}", (int)(bmrF * 1.55)); break;
                case 5: Console.WriteLine("{0:0}", (int)(bmrF * 1.55)); break;
                case 6: Console.WriteLine("{0:0}", (int)(bmrF * 1.55)); break;
                case 7: Console.WriteLine("{0:0}", (int)(bmrF * 1.725)); break;
                case 8: Console.WriteLine("{0:0}", (int)(bmrF * 1.725)); break;
                case 9: Console.WriteLine("{0:0}", (int)(bmrF * 1.725)); break;

                default: Console.WriteLine("{0:0}", (int)(bmrF * 1.9)); break;
            }
        }
    }
}