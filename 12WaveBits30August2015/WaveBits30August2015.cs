using System;

class WaveBits30August2015
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ((number & 1) == 0)
        {
            Console.WriteLine("The number {0} is EVEN", number);
        }
        else if ((number & 1) != 0)
        {
            Console.WriteLine("the number {0} is ODD", number);
        }
        
        //int number = int.Parse(Console.ReadLine());
        //int position = int.Parse(Console.ReadLine());

        //int mask = 1 << position;
        //int result = mask & number;
        //result = result >> position;

        //Console.WriteLine(result);

        
        
        
        //ulong number = ulong.Parse(Console.ReadLine());

        //for (int i = 0; i < 64; i++)
        //{

        //}
    }
}