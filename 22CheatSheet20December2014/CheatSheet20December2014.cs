using System;

class CheatSheet20December2014
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        long verticalStart = long.Parse(Console.ReadLine());
        long horizontalStart = long.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                long currentValue = (verticalStart + i) * (horizontalStart + j);
                Console.Write(currentValue + " ");
            }
            Console.WriteLine();
        }
    }
}